using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class StudentPaymentRepository
    {
        private SqlConnection _connection;

        public StudentPaymentRepository(string connectionString) 
        {
            _connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public Dictionary<string, bool> CheckStudentPaymentRequirements(string studentNumber, string monthOfPayment)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = {"ProofOfPayment"};

            _connection.Open();
            foreach (var column in columns)
            {
                string query = $"SELECT {column} FROM StudentPayment WHERE StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment";
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
                bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                requirements[column] = !hasRequirement;
            }
            _connection.Close();

            return requirements;
        }

        public void ViewFile(string column, string studentNumber, string monthOfPayment)
        {
            string query = $"SELECT {column} FROM StudentPayment WHERE StudentNumber = '{studentNumber}' AND MonthOfPayment = '{monthOfPayment}'";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            byte[] fileData = (byte[])command.ExecuteScalar();
            _connection.Close();

            PDFViewer pdfViewer = new PDFViewer(fileData);
            pdfViewer.Show();
        }

        public void ViewImageFile(string column, string studentNumber, string monthOfPayment)
        {
            string query = $"SELECT {column} FROM StudentPayment WHERE StudentNumber = '{studentNumber}' AND MonthOfPayment = '{monthOfPayment}'";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            MemoryStream ms = new MemoryStream();
            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0][column]);
                ms = new MemoryStream(data);
            }

            ImageViewer imageViewer = new ImageViewer(ms);
            imageViewer.Show();
        }

        public void UploadFile(string column, string studentNumber, string monthOfPayment, byte[] fileData)
        {
            string query = $"UPDATE StudentPayment SET {column} = @FileData WHERE StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@FileData", fileData);
            command.Parameters.AddWithValue("@StudentNumber", studentNumber);
            command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteFile(string column, string studentNumber, string monthOfPayment)
        {
            string query = $"UPDATE StudentPayment SET {column} = NULL WHERE StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@StudentNumber", studentNumber);
            command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<string> GetStudentPaymentData(string column)
        {
            List<string> studentDataList = new List<string>();
            string query = $"SELECT {column} FROM StudentPayment WHERE MonthOfPayment = 'August'";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader[column].ToString().Equals(string.Empty))
                    {
                        studentDataList.Add(reader[column].ToString());
                    }
                }
            }
            _connection.Close();
            return studentDataList;
        }
    }
}

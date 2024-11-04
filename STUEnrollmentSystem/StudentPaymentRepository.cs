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
    internal class StudentPaymentRepository : BaseRepository
    {
        public string MonthOfPayment {  get; set; }

        public StudentPaymentRepository(string connectionString) : base(connectionString) { }

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

        public override void ViewImageFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
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

            frmImageViewer imageViewer = new frmImageViewer(ms);
            imageViewer.Show();
        }

        public override void UploadFile(string table, string column, string condition, string ID, byte[] fileData)
        {
            string query = $"UPDATE {table} SET {column} = @FileData WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@FileData", fileData);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public override void DeleteFile(string table, string column, string condition, string ID)
        {
            string query = $"UPDATE {table} SET {column} = NULL WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public override List<string> GetColumnData(string table, string column)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT {column} FROM {table} WHERE MonthOfPayment = 'August'";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader[column].ToString().Equals(string.Empty))
                    {
                        columnDataList.Add(reader[column].ToString());
                    }
                }
            }
            _connection.Close();
            return columnDataList;
        }
    }
}

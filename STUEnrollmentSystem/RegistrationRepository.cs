using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class RegistrationRepository
    {
        private SqlConnection _connection;

        public RegistrationRepository(string connectionString)
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

        public Dictionary<string, bool> CheckRegistrationRequirements(string registerID)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate" };

            _connection.Open();
            foreach (var column in columns)
            {
                string query = $"SELECT {column} FROM Registration WHERE RegisterID = @RegisterID";
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@RegisterID", registerID);
                bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                requirements[column] = !hasRequirement;
            }
            _connection.Close();

            return requirements;
        }

        public void InsertPendingStudent(Dictionary<string, object> studentData)
        {
            var query = "INSERT INTO PendingStudents (RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                        "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) " +
                        "VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                        "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)";

            SqlCommand command = new SqlCommand(query, _connection);

            foreach (var key in studentData.Keys)
            {
                command.Parameters.AddWithValue($"@{key}", studentData[key]);
            }

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteRegistration(string registerId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Registration WHERE RegisterID = @RegisterID", _connection);
            command.Parameters.AddWithValue("@RegisterID", registerId);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void ViewFile(string column, string registerID)
        {
            string query = $"SELECT {column} FROM Registration WHERE RegisterID = {registerID}";
            PDFViewer pdfViewer = new PDFViewer(column, query);
            pdfViewer.Show();
        }

        public void UploadFile(string column, string registerID, byte[] fileData)
        {
            string query = $"UPDATE Registration SET {column} = @FileData WHERE RegisterID = @RegisterID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@FileData", fileData);
            command.Parameters.AddWithValue("@RegisterID", registerID);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteFile(string column, string registerID)
        {
            string query = $"UPDATE Registration SET {column} = NULL WHERE RegisterID = @RegisterID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@RegisterID", registerID);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateRequirements(string table, string column, string registerID)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM Registration WHERE RegisterID = {registerID}", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
            command.Parameters.AddWithValue("@RegisterID", registerID);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

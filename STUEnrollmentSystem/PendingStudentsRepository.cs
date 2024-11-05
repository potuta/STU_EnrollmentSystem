using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class PendingStudentsRepository : BaseRepository
    {
        public PendingStudentsRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to PendingStudentsRepository can be added here

        public Dictionary<string, bool> CheckPendingStudentsRequirements(string registerID)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate", "ProofOfPayment"};

            _connection.Open();
            foreach (var column in columns)
            {
                string query = $"SELECT {column} FROM PendingStudents WHERE RegisterID = @RegisterID";
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@RegisterID", registerID);
                bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                requirements[column] = !hasRequirement;
            }
            _connection.Close();

            return requirements;
        }

        public void InsertStudents(Dictionary<string, object> studentData)
        {
            var query = "INSERT INTO Students (RegisterID, StudentNumber, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentStatus, EnrollmentType, PaymentType, " +
                        "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) " +
                        "VALUES (@RegisterID, @StudentNumber, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentStatus, @EnrollmentType, @PaymentType, " +
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

        public void InsertStudentPayment(Dictionary<string, object> studentPaymentData, string monthOfPayment, string paymentStatus)
        {
            var query = "INSERT INTO StudentPayment(PaymentCode, PaymentMethod, StudentNumber, MonthOfPayment, PaymentStatus)" +
                        "VALUES (@PaymentCode, @PaymentMethod, @StudentNumber, @MonthOfPayment, @PaymentStatus)";

            SqlCommand command = new SqlCommand(query, _connection);

            foreach (var key in studentPaymentData.Keys)
            {
                command.Parameters.AddWithValue($"@{key}", studentPaymentData[key]);
            }
            command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
            command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeletePendingStudents(string registerId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM PendingStudents WHERE RegisterID = @RegisterID", _connection);
            command.Parameters.AddWithValue("@RegisterID", registerId);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateRequirements(string table, string column, string registerID)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = {registerID}", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
            command.Parameters.AddWithValue("@RegisterID", registerID);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateProofOfPayment(string table, string column, string registerID, string studentNumber)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = {registerID}", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE StudentNumber = @StudentNumber AND MonthOfPayment = 'August'";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
            command.Parameters.AddWithValue("@StudentNumber", studentNumber);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public int GenerateStudentNumber()
        {
            string query = "SELECT MAX(RegisterID) FROM Students";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            int studentCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
            _connection.Close();

            return studentCount;
        }
    }
}

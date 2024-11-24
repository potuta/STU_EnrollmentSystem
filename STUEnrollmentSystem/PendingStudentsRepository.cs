using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate", "ProofOfPayment", "PersonalEmail", "GuardianEmail"};

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM PendingStudents WHERE RegisterID = @RegisterID";
                    using(SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@RegisterID", registerID);
                        bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                        requirements[column] = !hasRequirement;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in CheckPendingStudentsRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return requirements;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckPendingStudentsRequirements: {ex.Message}");
                return requirements;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return requirements;
        }

        public void InsertStudents(Dictionary<string, object> studentData)
        {
            string query = "INSERT INTO Students (RegisterID, StudentNumber, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentStatus, EnrollmentType, PaymentType, " +
                        "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) " +
                        "VALUES (@RegisterID, @StudentNumber, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentStatus, @EnrollmentType, @PaymentType, " +
                        "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)";

            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertStudents to Students table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    foreach (var key in studentData.Keys)
                    {
                        command.Parameters.AddWithValue($"@{key}", studentData[key]);
                    }

                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in InsertStudents: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertStudents: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertStudents: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertStudents: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void InsertStudentPayment(Dictionary<string, object> studentPaymentData, string monthOfPayment, string paymentStatus, string schoolYear)
        {
            string query = "INSERT INTO StudentPayment(PaymentCode, PaymentMethod, StudentNumber, MonthOfPayment, PaymentStatus, SchoolYear)" +
                        "VALUES (@PaymentCode, @PaymentMethod, @StudentNumber, @MonthOfPayment, @PaymentStatus, @SchoolYear)";

            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertStudentPayment to StudentPayment table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    foreach (var key in studentPaymentData.Keys)
                    {
                        command.Parameters.AddWithValue($"@{key}", studentPaymentData[key]);
                    }
                    command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
                    command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in InsertStudentPayment: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertStudentPayment: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertStudentPayment: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertStudentPayment: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void DeletePendingStudents(string registerId)
        {
            string query = "DELETE FROM PendingStudents WHERE RegisterID = @RegisterID";

            try
            {
                LoggingService.LogInformation($"Deletion attempt in  DeletePendingStudents from PendingNewStudents table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RegisterID", registerId);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeletePendingStudents: {ex.Message}");
                LoggingService.LogError($"SQL Error in DeletePendingStudents: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeletePendingStudents: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DeletePendingStudents: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateRequirements(string table, string column, string registerID)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = {registerID}", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
                    command.Parameters.AddWithValue("@RegisterID", registerID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateRequirements: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateRequirements: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateProofOfPayment(string table, string column, string registerID, string studentNumber, string schoolYear)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = '{registerID}'", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE StudentNumber = @StudentNumber AND MonthOfPayment = 'August' AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateProofOfPayment: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateProofOfPayment: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public int GenerateStudentNumber()
        {
            int studentCount = 0;
            string query = "SELECT MAX(CAST(RegisterID AS INT)) FROM Students";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    studentCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateProofOfPayment: {ex.Message}");
                return studentCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateProofOfPayment: {ex.Message}");
                return studentCount;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return studentCount;
        }
    }
}

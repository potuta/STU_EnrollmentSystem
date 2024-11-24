using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class RegistrationRepository : BaseRepository
    {
        public RegistrationRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to RegistrationRepository can be added here

        public Dictionary<string, bool> CheckRegistrationRequirements(string registerID)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate", "PersonalEmail", "GuardianEmail" };

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM Registration WHERE RegisterID = @RegisterID";
                    using (SqlCommand command = new SqlCommand(query, _connection))
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
                Console.WriteLine($"SQL Error in CheckRegistrationRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return requirements;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckRegistrationRequirements: {ex.Message}");
                return requirements;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return requirements;
        }

        public void InsertPendingStudent(Dictionary<string, object> studentData)
        {
            string query = "INSERT INTO PendingStudents (RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                        "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) " +
                        "VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                        "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)";
            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertPendingStudent to PendingNewStudents table.");
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
                Console.WriteLine($"SQL Error in InsertPendingStudent: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertPendingStudent: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertPendingStudent: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertPendingStudent: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void DeleteRegistration(string registerId)
        {
            string query = "DELETE FROM Registration WHERE RegisterID = @RegisterID";
            try
            {
                LoggingService.LogInformation($"Deletion attempt in DeleteRegistration from Registration table.");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RegisterID", registerId);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeleteRegistration: {ex.Message}");
                LoggingService.LogError($"SQL Error in DeleteRegistration: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeleteRegistration: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DeleteRegistration: {ex.Message}");
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
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM Registration WHERE RegisterID = '{registerID}'", _connection);
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
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class UsersRepository : BaseRepository
    {
        public UsersRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to UsersRepository can be added here

        public bool VerifyUserLogin(string userID, string password)
        {
            string query = "SELECT * FROM Users WHERE UserID COLLATE SQL_Latin1_General_CP1_CS_AS = @UserID AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password";
            bool isUserVerified = false;

            try
            {
                LoggingService.LogInformation($"Verifying login attempt in VerifyUserLogin: UserID: {userID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    _connection.Open();
                    var result = command.ExecuteScalar();
                    //isUserVerified = command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
                    isUserVerified = result != null && result != DBNull.Value;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in VerifyUserLogin: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                LoggingService.LogError($"SQL Error in VerifyUserLogin. User not found or verified: UserID: {userID}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in VerifyUserLogin: {ex.Message}");
                LoggingService.LogError($"Unexpected error in VerifyUserLogin: User not found or verified: UserID: {userID}, {ex.Message}");
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return isUserVerified;
        }

        public List<string> GetUserLoginInfo(string userID, string password)
        {
            List<string> userLoginInfo = new List<string>();
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Password = @Password";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                userLoginInfo.Add(reader.GetString(column));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetUserLoginInfo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetUserLoginInfo: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return userLoginInfo;
        }

        public void UpdateUserPassword(string userID, string newPassword)
        {
            string query = $"UPDATE Users SET Password = @Password WHERE UserID = @UserID";
            try
            {
                LoggingService.LogInformation($"Update password attempt in UpdateUserPassword: UserID {userID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateUserPassword: {ex.Message}");
                LoggingService.LogError($"SQL Error in UpdateUserPassword: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateUserPassword: {ex.Message}");
                LoggingService.LogError($"Unexpected error in UpdateUserPassword: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            LoggingService.LogInformation($"Update password successful in UpdateUserPassword: UserID {userID}");
        }

        public string GetEmail(string userID)
        {
            string query = $"SELECT Email FROM Users WHERE UserID COLLATE SQL_Latin1_General_CP1_CS_AS = @UserID";
            string email = string.Empty;

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@UserID", userID);
                    email = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetEmail: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetEmail: {ex.Message}");
                return null;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return email;
        }
    }
}

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

        public bool VerifyUserLogin(string userID, string username, string password)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password";
            bool isUserVerified = false;

            try
            {
                LoggingService.LogInformation($"Verifying login attempt in VerifyUserLogin: UserID: {userID} Username: {username}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    _connection.Open();
                    isUserVerified = command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in VerifyUserLogin: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                LoggingService.LogError($"SQL Error in VerifyUserLogin. User not found or verified: UserID: {userID} Username: {username}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in VerifyUserLogin: {ex.Message}");
                LoggingService.LogError($"Unexpected error in VerifyUserLogin: User not found or verified: UserID: {userID} Username: {username}, {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return isUserVerified;
        }

        public List<string> GetUserLoginInfo(string userID, string username, string password)
        {
            List<string> userLoginInfo = new List<string>();
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Username", username);
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
    }
}

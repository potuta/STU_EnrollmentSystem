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

        public bool VerifyUserLogin(string userID, string username, string password)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            _connection.Open();
            bool isUserVerified = command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
            _connection.Close();

            return isUserVerified;
        }

        public List<string> GetUserLoginInfo(string userID, string username, string password)
        {
            List<string> userLoginInfo = new List<string>();
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, _connection);
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
            _connection.Close();
            return userLoginInfo;
        }
    }
}

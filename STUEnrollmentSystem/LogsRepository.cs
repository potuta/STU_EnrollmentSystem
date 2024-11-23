using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class LogsRepository : BaseRepository
    {
        public LogsRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to LogsRepository can be added here

        public List<Dictionary<string, string>> GetLogsFromDatabase(string year, string month, string day)
        {
            var logs = new List<Dictionary<string, string>>();
            string query = $"SELECT TimeStamp, Level, Message, Exception FROM Logs WHERE CAST(Timestamp AS DATE) = @TimeStamp ORDER BY Timestamp DESC";
            string[] dateParts = { year, month, day };
            string dateTimeStamp = string.Join("-", dateParts);

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@TimeStamp", dateTimeStamp);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var log = new Dictionary<string, string>
                            {
                                { "TimeStamp", reader["TimeStamp"].ToString() },
                                { "Level", reader["Level"].ToString() },
                                { "Message", reader["Message"].ToString() },
                                { "Exception", reader["Exception"].ToString() }
                            };
                            logs.Add(log);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GetLogsFromDatabase: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetLogsFromDatabase: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return logs;
        }
    }
}

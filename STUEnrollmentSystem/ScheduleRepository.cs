using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class ScheduleRepository : IConnectionRepository
    {
        private SqlConnection _connection;

        public ScheduleRepository(string connectionString)
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

        public string GetConnectionString()
        {
            return _connection.ConnectionString;
        }
        public List<string> GetScheduleData(string column)
        {
            List<string> scheduleDataList = new List<string>();
            string query = $"SELECT {column} FROM Schedule";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader[column].ToString().Equals(string.Empty))
                    {
                        scheduleDataList.Add(reader[column].ToString());
                    }
                }
            }
            _connection.Close();
            return scheduleDataList;
        }
    }
}

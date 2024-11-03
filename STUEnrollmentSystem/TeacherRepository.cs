using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class TeacherRepository : IConnectionRepository
    {
        private SqlConnection _connection;

        public TeacherRepository(string connectionString)
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

        public int GenerateTeacherCode()
        {
            string query = "SELECT COUNT(*) FROM Teachers";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            int teacherCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
            _connection.Close();
            return teacherCount;
        }

        public List<string> GetTeacherData(string column)
        {
            List<string> teacherDataList = new List<string>();
            string query = $"SELECT {column} FROM Teachers";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader[column].ToString().Equals(string.Empty))
                    {
                        teacherDataList.Add(reader[column].ToString());
                    }
                }
            }
            _connection.Close();
            return teacherDataList;
        }
    }
}

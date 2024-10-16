using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class SectionRepository
    {
        private SqlConnection _connection;

        public SectionRepository(string connectionString)
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

        public List<string> GetSectionData(string column)
        {
            List<string> sectionDataList = new List<string>();
            string query = $"SELECT {column} FROM Sections";
            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    sectionDataList.Add(reader[column].ToString());
                }
            }
            _connection.Close();
            return sectionDataList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    class PricesRepository
    {
        private SqlConnection _connection;

        public PricesRepository(string connectionString)
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

        public List<string> GetPricesData(string column)
        {
            List<string> pricesDataList = new List<string>();
            string query = $"SELECT {column} FROM Prices";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader[column].ToString().Equals(string.Empty))
                    {
                        pricesDataList.Add(reader[column].ToString());
                    }
                }
            }
            _connection.Close();
            return pricesDataList;
        }
    }
}

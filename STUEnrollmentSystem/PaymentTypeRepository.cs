using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class PaymentTypeRepository : BaseRepository
    {
        public PaymentTypeRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to PaymentTypeRepository can be added here

        public Dictionary<string, int> GetPaymentAmount(string paymentType, string pricesCode)
        {
            Dictionary<string, int> paymentAmountDictionary = new Dictionary<string, int>();
            List<int> paymentAmountList = new List<int>();
            List<string> monthsList = new List<string>();

            string paymentAmountCommand = $"SELECT PaymentAmount FROM PaymentType WHERE PaymentType = '{paymentType}' AND PricesCode = '{pricesCode}'";
            string monthCommand = $"SELECT Month FROM PaymentType WHERE PaymentType = '{paymentType}' AND PricesCode = '{pricesCode}'";

            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = _connection;
                    _connection.Open();

                    command.CommandText = paymentAmountCommand;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                paymentAmountList.Add(reader.GetInt32(column));
                            }
                        }
                    }

                    command.CommandText = monthCommand;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                monthsList.Add(reader.GetString(column));
                            }
                        }
                    }
                }

                foreach (string month in monthsList)
                {
                    foreach (int amount in paymentAmountList)
                    {
                        paymentAmountDictionary[month] = amount;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetPaymentAmount: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetPaymentAmount: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return paymentAmountDictionary;
        }

        public int GetMonthCount(string paymentType, string pricesCode)
        {
            string query = $"SELECT Month FROM PaymentType WHERE PaymentType = '{paymentType}' AND PricesCode = '{pricesCode}'";
            List<string> monthsList = new List<string>();

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                monthsList.Add(reader.GetString(column));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetMonthCount: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetMonthCount: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return monthsList.Count;
        }
    }
}

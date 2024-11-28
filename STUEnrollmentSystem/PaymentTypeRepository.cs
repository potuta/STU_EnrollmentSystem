﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

                for (int i = 0; i < monthsList.Count; i++)
                {
                    paymentAmountDictionary[monthsList[i]] = paymentAmountList[i];
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetPaymentAmount: {ex.Message}");
                return paymentAmountDictionary;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetPaymentAmount: {ex.Message}");
                return paymentAmountDictionary;
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
                return monthsList.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetMonthCount: {ex.Message}");
                return monthsList.Count;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return monthsList.Count;
        }

        public void UpdatePaymentTypeSchoolYear(string schoolYear)
        {
            string query = $"UPDATE PaymentType SET SchoolYear = '{schoolYear}' WHERE PaymentType IN ('Monthly', 'Full')";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdatePaymentTypeSchoolYear: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdatePaymentTypeSchoolYear: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}

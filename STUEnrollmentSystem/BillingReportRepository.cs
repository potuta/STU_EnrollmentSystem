﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class BillingReportRepository : BaseRepository
    {
        public BillingReportRepository(string connectionString) : base (connectionString){ }

        // Additional methods specific to BillingReportRepository can be added here

        public int GenerateTransactionNumber()
        {
            int number = 0;
            string query = $"SELECT MAX(CAST(TransactionNumber AS INT)) FROM BillingReport";

            try
            {
                using (SqlCommand command = new SqlCommand (query, _connection))
                {
                    _connection.Open();
                    number = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GenerateTransactionNumber: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateTransactionNumber: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return number;
        }

        public bool CheckIfTransactionNumberExists(string transactionNumber)
        {
            bool result = false;
            string query = $"SELECT TransactionNumber FROM BillingReport WHERE TransactionNumber = @TransactionNumber";

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@TransactionNumber", transactionNumber);
                    result = command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in CheckIfTransactionNumberExists: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckIfTransactionNumberExists: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return result;
        }
    }
}
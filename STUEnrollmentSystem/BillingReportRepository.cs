using System;
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
            int result = 0;
            int number = 0;
            string query = $"SELECT MAX(CAST(TransactionNumber AS INT)) FROM BillingReport";
            List<string> transactionNumberList = GetColumnData("StudentPayment", "TransactionNumber");
            List<int> transactionNumberIntList = new List<int>();

            try
            {
                using (SqlCommand command = new SqlCommand (query, _connection))
                {
                    _connection.Open();
                    var data = command.ExecuteScalar();

                    if (data != null && data != DBNull.Value)
                    {
                        number = Convert.ToInt32(data) + 1;
                    }
                    else
                    {
                        number = 1;
                    }
                }

                foreach (string num in transactionNumberList)
                {
                    if (num != null)
                    {
                        transactionNumberIntList.Add(int.Parse(num) + 1);
                    }
                }

                if (transactionNumberList.Count < 1)
                {
                    transactionNumberIntList.Add(1);
                }

                result = Math.Max(transactionNumberIntList.Max(), number);
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GenerateTransactionNumber: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateTransactionNumber: {ex.Message}");
                return result;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return result;
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
                    var data = command.ExecuteScalar();
                    result = data != null && data != DBNull.Value;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in CheckIfTransactionNumberExists: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckIfTransactionNumberExists: {ex.Message}");
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return result;
        }

        public DataTable GetTotalEarningsAsDataTable()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT SUM(PaymentAmount) AS 'Total Earnings' FROM BillingReport";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetTotalEarningsAsDataTable: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalEarningsAsDataTable: {ex.Message}");
                return dataTable;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return dataTable;
        }
    }
}

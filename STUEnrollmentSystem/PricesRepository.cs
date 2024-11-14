using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    class PricesRepository : BaseRepository
    {
        public PricesRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to PricesRepository can be added here

        public int GetPaymentAmountPerGrade(string paymentType, string grade)
        {
            switch (grade)
            {
                case "Grade 7":
                    grade = "PG7";
                    break;
                case "Grade 8":
                    grade = "PG8";
                    break;
                case "Grade 9":
                    grade = "PG9";
                    break;
                case "Grade 10":
                    grade = "PG10";
                    break;
            }

            int total = 0;

            //if (paymentType.Equals("Monthly"))
            //{
            //    List<int> amountList = new List<int>();
            //    string query = $"SELECT TuitionFee, Books, LaboratoryFee, Uniform, MiscellanaousFee FROM Prices WHERE GradeCode = '{grade}'";
            //    SqlCommand command = new SqlCommand(query, _connection);
            //    _connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            for (int column = 0; column < reader.FieldCount; column++)
            //            {
            //                amountList.Add(reader.GetInt32(column));
            //            }
            //        }
            //    }
            //    _connection.Close();

            //    foreach (int amount in amountList)
            //    {
            //        total += amount;
            //    }

            //    total = total / 10;
            //}
            //else if (paymentType.Equals("Full"))
            //{
            //    string query = $"SELECT TotalAmount FROM Prices WHERE GradeCode = '{grade}'";
            //    SqlCommand command = new SqlCommand(query, _connection);
            //    _connection.Open();
            //    total = Convert.ToInt32(command.ExecuteScalar());
            //    _connection.Close();
            //}

            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = _connection;
                    _connection.Open();

                    if (paymentType.Equals("Monthly", StringComparison.OrdinalIgnoreCase))
                    {
                        command.CommandText = "SELECT TuitionFee, Books, LaboratoryFee, Uniform, MiscellanaousFee FROM Prices WHERE PriceCode = @PriceCode";
                        command.Parameters.AddWithValue("@PriceCode", grade);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int column = 0; column < reader.FieldCount; column++)
                                {
                                    total += reader.GetInt32(column);
                                }
                            }
                        }

                        int monthCount = new PaymentTypeRepository(_connection.ConnectionString).GetMonthCount(paymentType, grade);

                        total /= monthCount;
                    }
                    else if (paymentType.Equals("Full", StringComparison.OrdinalIgnoreCase))
                    {
                        command.CommandText = "SELECT TotalAmount FROM Prices WHERE PriceCode = @PriceCode";
                        command.Parameters.AddWithValue("@PriceCode", grade);

                        total = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetPaymentAmountPerGrade: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetPaymentAmountPerGrade: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return total;
        }

        public List<int> GetPaymentAmountListFromGradeCode(string gradeCode)
        {
            List<int> paymentAmountList = new List<int>();
            string query = $"SELECT TuitionFee, Books, LaboratoryFee, Uniform, MiscellanaousFee, TotalAmount FROM Prices WHERE GradeCode = @GradeCode";

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@GradeCode", gradeCode);

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
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetPaymentAmountList: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetPaymentAmountList: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return paymentAmountList;
        }
    }
}

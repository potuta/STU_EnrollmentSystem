using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                    grade = "G7";
                    break;
                case "Grade 8":
                    grade = "G8";
                    break;
                case "Grade 9":
                    grade = "G9";
                    break;
                case "Grade 10":
                    grade = "G10";
                    break;
            }

            int total = 0;

            if (paymentType.Equals("Monthly"))
            {
                List<int> amountList = new List<int>();
                string query = $"SELECT TuitionFee, Books, LaboratoryFee, Uniform, MiscellanaousFee FROM Prices WHERE GradeCode = '{grade}'";
                SqlCommand command = new SqlCommand(query, _connection);
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int column = 0; column < reader.FieldCount; column++)
                        {
                            amountList.Add(reader.GetInt32(column));
                        }
                    }
                }
                _connection.Close();

                foreach (int amount in amountList)
                {
                    total += amount;
                }

                total = total / 10;
            }
            else if (paymentType.Equals("Full"))
            {
                string query = $"SELECT TotalAmount FROM Prices WHERE GradeCode = '{grade}'";
                SqlCommand command = new SqlCommand(query, _connection);
                _connection.Open();
                total = Convert.ToInt32(command.ExecuteScalar());
                _connection.Close();
            }

            return total;
        }
    }
}

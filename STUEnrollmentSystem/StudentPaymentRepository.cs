using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class StudentPaymentRepository : BaseRepository
    {
        public string MonthOfPayment {  get; set; }
        public string SchoolYear { get; set; }

        public StudentPaymentRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to StudentPaymentRepository can be added here

        public Dictionary<string, bool> CheckStudentPaymentRequirements(string studentNumber, string monthOfPayment)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = {"ProofOfPayment"};

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM StudentPayment WHERE StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear";
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
                        command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                        bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                        requirements[column] = !hasRequirement;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in CheckStudentPaymentRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckStudentPaymentRequirements: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return requirements;
        }

        public List<string> CheckMonthlyPendingPaymentStatus(string studentNumber)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT MonthOfPayment FROM StudentPayment WHERE StudentNumber = @StudentNumber AND PaymentStatus = 'Pending'";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader["MonthOfPayment"].ToString().Equals(string.Empty))
                            {
                                columnDataList.Add(reader["MonthOfPayment"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in CheckMonthlyPendingPaymentStatus: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckMonthlyPendingPaymentStatus: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return columnDataList;
        }

        public Dictionary<string, int> GetTotalPendingPaymentAmount(string studentNumber, string paymentCode)
        {
            Dictionary<string, int> totalPendingPaymentAmount = new Dictionary<string, int>();
            List<string> monthlyPendingDataList = CheckMonthlyPendingPaymentStatus(studentNumber);

            try
            {
                _connection.Open();
                foreach (string month in monthlyPendingDataList)
                {
                    string query = $"SELECT PaymentAmount FROM PaymentType WHERE PaymentCode = @PaymentCode AND Month = @Month";
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                        command.Parameters.AddWithValue("@Month", month);
                        totalPendingPaymentAmount[month] = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetTotalPendingPaymentAmount: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalPendingPaymentAmount: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return totalPendingPaymentAmount;
        }

        public override void ViewImageFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    MemoryStream ms = new MemoryStream();
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0][column]);
                        ms = new MemoryStream(data);
                    }

                    frmImageViewer imageViewer = new frmImageViewer(ms);
                    imageViewer.Show();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in ViewImageFile: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in ViewImageFile: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public override void UploadFile(string table, string column, string condition, string ID, byte[] fileData)
        {
            string query = $"UPDATE {table} SET {column} = @FileData WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@FileData", fileData);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UploadFile: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UploadFile: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public override void DeleteFile(string table, string column, string condition, string ID)
        {
            string query = $"UPDATE {table} SET {column} = NULL WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeleteFile: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeleteFile: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public override List<string> GetColumnData(string table, string column)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT {column} FROM {table} WHERE MonthOfPayment = 'August'";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader[column].ToString().Equals(string.Empty))
                            {
                                columnDataList.Add(reader[column].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetColumnData: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetColumnData: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return columnDataList;
        }
    }
}

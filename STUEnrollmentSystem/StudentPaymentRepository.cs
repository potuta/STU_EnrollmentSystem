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
                return requirements;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckStudentPaymentRequirements: {ex.Message}");
                return requirements;
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
                return columnDataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckMonthlyPendingPaymentStatus: {ex.Message}");
                return columnDataList;
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
                return totalPendingPaymentAmount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalPendingPaymentAmount: {ex.Message}");
                return totalPendingPaymentAmount;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return totalPendingPaymentAmount;
        }

        public int GetTotalPaymentAmountFromMonth(string paymentCode, string month)
        {
            int totalPaymentAmount = 0;

            try
            {
                _connection.Open();
                string query = $"SELECT PaymentAmount FROM PaymentType WHERE PaymentCode = @PaymentCode AND Month = @Month";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                    command.Parameters.AddWithValue("@Month", month);
                    totalPaymentAmount = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetTotalPendingPaymentAmount: {ex.Message}");
                return totalPaymentAmount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalPendingPaymentAmount: {ex.Message}");
                return totalPaymentAmount;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return totalPaymentAmount;
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
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in ViewImageFile: {ex.Message}");
                return;
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
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UploadFile: {ex.Message}");
                return;
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
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeleteFile: {ex.Message}");
                return;
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
                return columnDataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetColumnData: {ex.Message}");
                return columnDataList;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return columnDataList;
        }

        public int GetStudentNotificationCount(string studentNumber, string paymentCode, string schoolYear, string monthOfPayment)
        {
            int count = 0;
            string query = $"SELECT NotificationCount FROM StudentPayment WHERE SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode AND StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();

                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
                    command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);

                    count = command.ExecuteScalar().Equals(DBNull.Value) ? 0 : Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetStudentNotificationCount: {ex.Message}");
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetStudentNotificationCount: {ex.Message}");
                return count;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return count;
        }

        public void UpdateStudentNotificationCount(string studentNumber, string paymentCode, string schoolYear, string monthOfPayment)
        {
            int count = GetStudentNotificationCount(studentNumber, paymentCode, schoolYear, monthOfPayment) + 1;
            string query = $"UPDATE StudentPayment SET NotificationCount = @NotificationCount WHERE SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode AND StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment";

            try
            {
                using (SqlCommand command = new SqlCommand(@query, _connection))
                {
                    _connection.Open();

                    command.Parameters.AddWithValue("@NotificationCount", count);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
                    command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateStudentNotificationCount: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateStudentNotificationCount: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        
        public void InsertBillingReport(Dictionary<string, object> billingReportData)
        {
            string query = "INSERT INTO BillingReport(TransactionNumber, StudentNumber, PaymentAmount, TransactionDate, PaymentRN, ReceiptRN)"+
                            "VALUES (@TransactionNumber, @StudentNumber, @PaymentAmount, @TransactionDate, @PaymentRN, @ReceiptRN)";

            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertBillingReport to BillingReport table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    foreach (var key in billingReportData.Keys)
                    {
                        command.Parameters.AddWithValue($"@{key}", billingReportData[key]);
                    }
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in InsertBillingReport: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertBillingReport: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertBillingReport: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertBillingReport: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
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
        public string PaymentCode {  get; set; }

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
                    string query = $"SELECT {column} FROM StudentPayment WHERE StudentNumber = @StudentNumber AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode";
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
                        command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                        command.Parameters.AddWithValue("@PaymentCode", PaymentCode);
                        //bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
                        var result = command.ExecuteScalar();
                        bool hasRequirement = result != null && result != DBNull.Value;
                        requirements[column] = hasRequirement;
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

        public List<string> CheckMonthlyPendingPaymentStatus(string studentNumber, string paymentCode, string schoolYear)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT MonthOfPayment FROM StudentPayment WHERE StudentNumber = @StudentNumber AND PaymentCode = @PaymentCode AND PaymentStatus = 'Pending' AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
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

        // WIP
        public Dictionary<string, string> GetMonthlyAndSchoolYearPendingPaymentStatus(string studentNumber, string paymentCode)
        {
            string query = $"SELECT SchoolYear, MonthOfPayment FROM StudentPayment WHERE StudentNumber = @StudentNumber AND PaymentCode = @PaymentCode AND PaymentStatus = 'Pending'";
            Dictionary<string, string> monthlyAndSY = new Dictionary<string, string>();
            try
            {

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetMonthlyAndSchoolYearPendingPaymentStatus: {ex.Message}");
                return monthlyAndSY;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetMonthlyAndSchoolYearPendingPaymentStatus: {ex.Message}");
                return monthlyAndSY;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            return monthlyAndSY;
        }

        public string GetPaymentCode(string studentNumber, string schoolYear)
        {
            string paymentCode = string.Empty;
            string query = $"SELECT PaymentCode FROM StudentPayment WHERE StudentNumber = @StudentNumber AND MonthOfPayment = 'August' AND SchoolYear = @SchoolYear";

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
                    paymentCode = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetPaymentCode: {ex.Message}");
                return paymentCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetPaymentCode: {ex.Message}");
                return paymentCode;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            return paymentCode;
        }

        public override void ViewImageFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                    command.Parameters.AddWithValue("@PaymentCode", PaymentCode);

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
            string query = $"UPDATE {table} SET {column} = @FileData WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode";

            try
            {
                LoggingService.LogInformation($"Upload attempt in UploadFile: Table: {table} Column: {column} ID: {ID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@FileData", fileData);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                    command.Parameters.AddWithValue("@PaymentCode", PaymentCode);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UploadFile: {ex.Message}");
                LoggingService.LogError($"SQL Error in UploadFile: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UploadFile: {ex.Message}");
                LoggingService.LogError($"Unexpected error in UploadFile: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            LoggingService.LogInformation($"Upload successful in UploadFile: Table: {table} Column: {column} ID: {ID}");
        }

        public override void DeleteFile(string table, string column, string condition, string ID)
        {
            string query = $"UPDATE {table} SET {column} = NULL WHERE {condition} = @ID AND MonthOfPayment = @MonthOfPayment AND SchoolYear = @SchoolYear AND PaymentCode = @PaymentCode";

            try
            {
                LoggingService.LogInformation($"Deletion attempt in DeleteFile: Table: {table} Column: {column} ID: {ID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@MonthOfPayment", MonthOfPayment);
                    command.Parameters.AddWithValue("@SchoolYear", SchoolYear);
                    command.Parameters.AddWithValue("@PaymentCode", PaymentCode);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeleteFile: {ex.Message}");
                LoggingService.LogError($"SQL Error in DeleteFile: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeleteFile: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DeleteFile: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            LoggingService.LogInformation($"Deletion successful in DeleteFile: Table: {table} Column: {column} ID: {ID}");
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

                    //count = command.ExecuteScalar().Equals(DBNull.Value) ? 0 : Convert.ToInt32(command.ExecuteScalar());
                    var data = command.ExecuteScalar();
                    if (data != null && data != DBNull.Value)
                    {
                        count = Convert.ToInt32(data);
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetStudentNotificationCount: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetStudentNotificationCount: {ex.Message}");
                return 0;
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
        
        public void InsertStudentPayment(Dictionary<string, object> studentPaymentData, int? paidAmount, string monthOfPayment, string paymentStatus, string schoolYear)
        {
            string query = "INSERT INTO StudentPayment(PaymentCode, PaymentMethod, StudentNumber, MonthOfPayment, PaymentStatus, SchoolYear, PaidAmount)" +
                        "VALUES (@PaymentCode, @PaymentMethod, @StudentNumber, @MonthOfPayment, @PaymentStatus, @SchoolYear, @PaidAmount)";

            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertStudentPayment to StudentPayment table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    foreach (var key in studentPaymentData.Keys)
                    {
                        command.Parameters.AddWithValue($"@{key}", studentPaymentData[key]);
                    }
                    command.Parameters.AddWithValue("@MonthOfPayment", monthOfPayment);
                    command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    if (paidAmount.HasValue)
                    {
                        command.Parameters.AddWithValue("@PaidAmount", paidAmount.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@PaidAmount", DBNull.Value);
                    }

                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in InsertStudentPayment: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertStudentPayment: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertStudentPayment: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertStudentPayment: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public int GetSumTotalPaidAmount(string studentNumber, string paymentCode, string schoolYear)
        {
            int total = 0;
            string query = $"SELECT SUM(PaidAmount) FROM StudentPayment WHERE StudentNumber = @StudentNumber AND PaymentCode = @PaymentCode AND SchoolYear = @SchoolYear";

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    total = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetSumTotalPaidAmount: {ex.Message}");
                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSumTotalPaidAmount: {ex.Message}");
                return total;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return total;
        }

        public DataTable GetReceiptRNDataTable(string receiptRN)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM StudentPayment WHERE ReceiptRN = @ReceiptRN";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ReceiptRN", receiptRN);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetReceiptRNDataTable: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetReceiptRNDataTable: {ex.Message}");
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

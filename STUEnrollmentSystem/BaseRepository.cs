using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    public class BaseRepository : ConnectionFactory
    {
        protected SqlConnection _connection;

        protected BaseRepository(string connectionString) : base(connectionString)
        {
            this._connection = _sourceConnectionString;
        }

        public virtual List<string> GetColumnData(string table, string column)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT {column} FROM {table}";

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
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GetColumnData: {ex.Message}");
                // Optionally, handle specific SQL error codes here
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

        public virtual void ViewPDFFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    _connection.Open();
                    byte[] fileData = (byte[])command.ExecuteScalar();
                    frmPDFViewer pdfViewer = new frmPDFViewer(fileData);
                    pdfViewer.Show();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in ViewPDFFile: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in ViewPDFFile: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public virtual void ViewImageFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
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

        public virtual void UploadFile(string table, string column, string condition, string ID, byte[] fileData)
        {
            string query = $"UPDATE {table} SET {column} = @FileData WHERE {condition} = @ID";

            try
            {
                LoggingService.LogInformation($"Upload attempt in UploadFile: Table: {table} Column: {column} ID: {ID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                { 
                    command.Parameters.AddWithValue("@FileData", fileData);
                    command.Parameters.AddWithValue("@ID", ID);
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

        public virtual void DeleteFile(string table, string column, string condition, string ID)
        {
            string query = $"UPDATE {table} SET {column} = NULL WHERE {condition} = @ID";

            try
            {
                LoggingService.LogInformation($"Deletion attempt in DeleteFile: Table: {table} Column: {column} ID: {ID}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
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
    }
}

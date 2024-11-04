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
    internal class BaseRepository : IConnectionRepository
    {
        protected SqlConnection _connection;

        protected BaseRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public string GetConnectionString()
        {
            return _connection.ConnectionString;
        }

        public virtual List<string> GetColumnData(string table, string column)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT {column} FROM {table}";
            SqlCommand command = new SqlCommand(query, _connection);
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
            _connection.Close();
            return columnDataList;
        }

        public virtual void ViewPDFFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@ID", ID);
            _connection.Open();
            byte[] fileData = (byte[])command.ExecuteScalar();
            _connection.Close();
            frmPDFViewer pdfViewer = new frmPDFViewer(fileData);
            pdfViewer.Show();
        }

        public virtual void ViewImageFile(string table, string column, string condition, string ID)
        {
            string query = $"SELECT {column} FROM {table} WHERE {condition} = @ID";
            SqlCommand command = new SqlCommand(query, _connection);
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

        public virtual void UploadFile(string table, string column, string condition, string ID, byte[] fileData)
        {
            string query = $"UPDATE {table} SET {column} = @FileData WHERE {condition} = @ID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@FileData", fileData);
            command.Parameters.AddWithValue("@ID", ID);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public virtual void DeleteFile(string table, string column, string condition, string ID)
        {
            string query = $"UPDATE {table} SET {column} = NULL WHERE {condition} = @ID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@ID", ID);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

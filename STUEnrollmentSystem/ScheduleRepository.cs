using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class ScheduleRepository : BaseRepository
    {
        public ScheduleRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to ScheduleRepository can be added here

        public List<string> GetColumnDataFromSectionCode(string column, string sectionCode)
        {
            List<string> columnDataList = new List<string>();
            string query = $"SELECT {column} FROM Schedule WHERE SectionCode = '{sectionCode}'";
            
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
                Console.WriteLine($"SQL Error in GetColumnDataFromSectionCode: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetColumnDataFromSectionCode: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return columnDataList;
        }

        public DataTable GetScheduleDataTableFromSectionCode(string sectionCode)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Schedule WHERE SectionCode = @SectionCode";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@SectionCode", sectionCode);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetScheduleDataTableFromSectionCode: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetScheduleDataTableFromSectionCode: {ex.Message}");
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

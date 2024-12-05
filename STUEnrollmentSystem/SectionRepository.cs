using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class SectionRepository : BaseRepository
    {
        public SectionRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to SectionRepository can be added here

        public string GetSectionCode(string sectionTitle)
        {
            string sectionCode = string.Empty;
            string query = $"SELECT SectionCode FROM Sections WHERE SectionTitle = @SectionTitle";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@SectionTitle", sectionTitle);
                    _connection.Open();
                    sectionCode = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GetSectionCode: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSectionCode: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return sectionCode;
        }

        public DataTable GetSectionDataTableFromSectionCode(string sectionCode)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Sections WHERE SectionCode = @SectionCode";

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
                Console.WriteLine($"SQL Error in GetSectionDataTableFromSectionCode: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSectionDataTableFromSectionCode: {ex.Message}");
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class TeacherRepository : BaseRepository
    {
        public TeacherRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to TeacherRepository can be added here

        public int GenerateTeacherCode()
        {
            string query = "SELECT COUNT(*) FROM Teachers";
            int teacherCount = 0;

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    var data = command.ExecuteScalar();

                    if (data != null && data != DBNull.Value)
                    {
                        teacherCount = Convert.ToInt32(data) + 1;
                    }
                    else
                    {
                        teacherCount = 1;
                    }
                    //teacherCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GenerateTeacherCode: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateTeacherCode: {ex.Message}");
                return 1;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return teacherCount;
        }

        public Dictionary<string, string> GetTeacherNameAndTeacherCodeDictionary(List<string> teacherCodeList)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    foreach (string teacherCode in teacherCodeList)
                    {
                        string query = $"SELECT TeacherName FROM Teachers WHERE TeacherCode = '{teacherCode}'";
                        command.CommandText = query;
                        command.Connection = _connection;
                        dictionary[teacherCode] = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetTeacherNameAndTeacherCode: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTeacherNameAndTeacherCode: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return dictionary;
        }

        public DataTable GetTotalTeachersAsDataTable()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT COUNT(*) AS 'Total Teachers' FROM Teachers";

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
                Console.WriteLine($"SQL Error in GetTotalTeachersAsDataTable: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalTeachersAsDataTable: {ex.Message}");
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

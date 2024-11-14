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
                    teacherCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in GenerateTeacherCode: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateTeacherCode: {ex.Message}");
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
    }
}

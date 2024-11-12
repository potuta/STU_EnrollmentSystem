using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class StudentRepository : BaseRepository
    {
        public StudentRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to StudentRepository can be added here

        public Dictionary<string, bool> CheckStudentRequirements(string studentNumber)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate", "PersonalEmail", "GuardianEmail" };

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM Students WHERE StudentNumber = @StudentNumber";
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        bool hasRequirement = command.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                        requirements[column] = !hasRequirement;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in CheckStudentRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckStudentRequirements: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return requirements;
        }

        public List<string> GetSectionsByGrade(string gradeCode)
        {
            List<string> sections = new List<string>();
            string query = "SELECT SectionTitle FROM Sections WHERE GradeCode = @GradeCode AND StudCount < Capacity";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@GradeCode", gradeCode);
                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sections.Add(reader["SectionTitle"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetSectionsByGrade: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSectionsByGrade: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return sections;
        }

        public DataTable GetTotalEnrolledStudentsByGrade()
        {
            DataTable dataTable = new DataTable();
            string query =
                "SELECT [Grade 7] AS 'Grade 7', [Grade 8] AS 'Grade 8', [Grade 9] AS 'Grade 9', [Grade 10] AS 'Grade 10', " +
                "(SELECT COUNT(*) FROM Students) AS 'Total Enrolled Students' " +
                "FROM (SELECT StudentNumber, EnrollmentType FROM Students) AS SourceTable " +
                "PIVOT (COUNT(StudentNumber) FOR EnrollmentType IN ([Grade 7], [Grade 8], [Grade 9], [Grade 10])) AS PivotTable";

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
                Console.WriteLine($"SQL Error in GetTotalEnrolledStudentsByGrade: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalEnrolledStudentsByGrade: {ex.Message}");
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;

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
                Console.WriteLine($"SQL Error in CheckStudentRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return requirements;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckStudentRequirements: {ex.Message}");
                return requirements;
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
                return sections;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSectionsByGrade: {ex.Message}");
                return sections;
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
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetTotalEnrolledStudentsByGrade: {ex.Message}");
                return dataTable;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return dataTable;
        }

        public Dictionary<string, string> GetStudentEmail(string studentNumber)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string[] columns = { "PersonalEmail", "GuardianEmail" };

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM Students WHERE StudentNumber = @StudentNumber";

                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        //string email = !command.ExecuteScalar().Equals(DBNull.Value) ? Convert.ToString(command.ExecuteScalar()) : string.Empty;
                        emails[column] = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetStudentEmail: {ex.Message}");
                return emails;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetStudentEmail: {ex.Message}");
                return emails;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            Console.WriteLine("PersonalEmail: " + emails.Values.ElementAt(0));
            Console.WriteLine("GuardianEmail: " + emails.Values.ElementAt(1));
            return emails;
        }

        public string GetStudentName(string studentNumber)
        {
            List<string> names = new List<string>();
            string query = $"SELECT StudFirstName, StudMidName, StudLastName FROM Students WHERE StudentNumber = @StudentNumber";

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
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                names.Add(reader.GetString(column));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetStudentName: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetStudentName: {ex.Message}");
                return null;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            string fullName = $"{names[0]} {names[1]} {names[2]}";
            return fullName;
        }

        public string GetStudentSection(string studentNumber)
        {
            string section = string.Empty;
            string query = $"SELECT Section FROM Students WHERE StudentNumber = @StudentNumber";

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    section = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetStudentSection: {ex.Message}");
                return section;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetStudentSection: {ex.Message}");
                return section;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return section;
        }

        public void InsertStudents(Dictionary<string, object> studentData)
        {
            string query = "INSERT INTO Students (RegisterID, StudentNumber, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentStatus, EnrollmentType, PaymentType, " +
                        "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) " +
                        "VALUES (@RegisterID, @StudentNumber, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentStatus, @EnrollmentType, @PaymentType, " +
                        "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)";

            try
            {
                LoggingService.LogInformation($"Insert attempt in InsertStudents to Students table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    foreach (var key in studentData.Keys)
                    {
                        command.Parameters.AddWithValue($"@{key}", studentData[key]);
                    }

                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in InsertStudents: {ex.Message}");
                LoggingService.LogError($"SQL Error in InsertStudents: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in InsertStudents: {ex.Message}");
                LoggingService.LogError($"Unexpected error in InsertStudents: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateStudentYearLevel(string studentNumber, string enrollmentType, string paymentType)
        {
            string query = $"UPDATE Students SET EnrollmentStatus = 'OLD', EnrollmentType = @EnrollmentType, PaymentType = @PaymentType, Section = NULL WHERE StudentNumber = @StudentNumber";

            try
            {
                LoggingService.LogInformation($"Update attempt in UpdateStudentYearLevel: StudentNumber: {studentNumber} EnrollmentType: {enrollmentType}");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@EnrollmentType", enrollmentType);
                    command.Parameters.AddWithValue("@PaymentType", paymentType);
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateStudentYearLevel: {ex.Message}");
                LoggingService.LogError($"SQL Error in UpdateStudentYearLevel: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateStudentYearLevel: {ex.Message}");
                LoggingService.LogError($"Unexpected error in UpdateStudentYearLevel: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            LoggingService.LogInformation($"Update successful in UpdateStudentYearLevel: StudentNumber: {studentNumber} EnrollmentType: {enrollmentType}");
        }
    }
}

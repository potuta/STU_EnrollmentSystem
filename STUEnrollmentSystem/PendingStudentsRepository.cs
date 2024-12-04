using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class PendingStudentsRepository : BaseRepository
    {
        public PendingStudentsRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to PendingStudentsRepository can be added here

        public Dictionary<string, bool> CheckPendingStudentsRequirements(string registerID)
        {
            Dictionary<string, bool> requirements = new Dictionary<string, bool>();
            string[] columns = { "StudForm137", "LRN", "GoodMoral", "BirthCertificate", "TransferCertificate", "ProofOfPayment", "PersonalEmail", "GuardianEmail"};

            try
            {
                _connection.Open();
                foreach (var column in columns)
                {
                    string query = $"SELECT {column} FROM PendingStudents WHERE RegisterID = @RegisterID";
                    using(SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@RegisterID", registerID);
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
                Console.WriteLine($"SQL Error in CheckPendingStudentsRequirements: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                return requirements;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in CheckPendingStudentsRequirements: {ex.Message}");
                return requirements;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return requirements;
        }

        public void DeletePendingStudents(string registerId)
        {
            string query = "DELETE FROM PendingStudents WHERE RegisterID = @RegisterID";

            try
            {
                LoggingService.LogInformation($"Deletion attempt in  DeletePendingStudents from PendingNewStudents table");
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RegisterID", registerId);
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeletePendingStudents: {ex.Message}");
                LoggingService.LogError($"SQL Error in DeletePendingStudents: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeletePendingStudents: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DeletePendingStudents: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateRequirements(string table, string column, string registerID)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = {registerID}", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
                    command.Parameters.AddWithValue("@RegisterID", registerID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateRequirements: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateRequirements: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateProofOfPayment(string table, string column, string registerID, string studentNumber, string schoolYear)
        {
            SqlCommand columnData = new SqlCommand($"SELECT {column} FROM PendingStudents WHERE RegisterID = '{registerID}'", _connection);
            string query = $"UPDATE {table} SET {column} = @Param WHERE StudentNumber = @StudentNumber AND MonthOfPayment = 'August' AND SchoolYear = @SchoolYear";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Param", columnData.ExecuteScalar());
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateProofOfPayment: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateProofOfPayment: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public int GenerateStudentNumber()
        {
            //string query = "SELECT MAX(CAST(RegisterID AS INT)) FROM Students";
            List<string> studentNumList = GetColumnData("Students", "StudentNumber");
            List<string> pendingStudentNumList = GetColumnData("PendingStudents", "StudentNumber");
            List<int> numList1 = new List<int>();
            List<int> numList2 = new List<int>();
            //int studentCount = 0;
            int result = 0;

            try
            {
                //using (SqlCommand command = new SqlCommand(query, _connection))
                //{
                //    _connection.Open();
                //    //studentCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
                //    var data = command.ExecuteScalar();
                //    if (data != null && data != DBNull.Value)
                //    {
                //        studentCount = Convert.ToInt32(data) + 1;
                //    }
                //    else
                //    {
                //        studentCount = 1;
                //    }
                //}

                foreach (string studentNum in studentNumList)
                {
                    if (studentNum != null)
                    {
                        string numParts = studentNum.Substring(1);
                        numList1.Add(int.Parse(numParts) + 1);
                    }
                }

                if (studentNumList.Count < 1)
                {
                    numList1.Add(1);
                }

                foreach (string pendingStudentNum in pendingStudentNumList)
                {
                    if (pendingStudentNum != null)
                    {
                        string numParts = pendingStudentNum.Substring(1);
                        numList2.Add(int.Parse(numParts) + 1);
                    }
                }

                if (pendingStudentNumList.Count < 1)
                {
                    numList2.Add(1);
                }

                //result = Math.Max(Math.Max(numList1.Max(), numList2.Max()), studentCount);
                result = Math.Max(numList1.Max(), numList2.Max());
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GenerateStudentNumber: {ex.Message}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GenerateStudentNumber: {ex.Message}");
                return result;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return result;
        }
    }
}

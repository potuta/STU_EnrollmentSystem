using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class SubjectsRepository : BaseRepository
    {
        public SubjectsRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to SubjectsRepository can be added here

        public DataTable GetSubjectsDataTableFromSubjectGradeCode(string subjectGradeCode)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Subjects WHERE SubjectGradeCode = @SubjectGradeCode";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@SubjectGradeCode", subjectGradeCode);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetSubjectsDataTableFromSubjectGradeCode: {ex.Message}");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSubjectsDataTableFromSubjectGradeCode: {ex.Message}");
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

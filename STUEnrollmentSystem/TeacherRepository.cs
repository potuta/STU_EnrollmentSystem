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
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            int teacherCount = command.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(command.ExecuteScalar()) + 1;
            _connection.Close();
            return teacherCount;
        }
    }
}

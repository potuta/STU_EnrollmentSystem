using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class RolesRepository : BaseRepository
    {
        public RolesRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to RolesRepository can be added here

        public List<string> GetRolesList()
        {
            List<string> roles = new List<string>();
            string query = "SELECT RoleName FROM Roles";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader["RoleName"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetRolesList: {ex.Message}");
                return roles;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetRolesList: {ex.Message}");
                return roles;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return roles;
        }

        public string GetRoleName(string roleID)
        {
            string query = "SELECT RoleName FROM Roles WHERE RoleID = @RoleID";
            string roleName = string.Empty;

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    roleName = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetRoleName: {ex.Message}");
                return roleName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetRoleName: {ex.Message}");
                return roleName;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return roleName;
        }

        public Dictionary<string, bool> GetRolePriviligesDictionary(string roleName)
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            string[] columns = { "Enrollment_Module", "Registration_SubModule", "ApprovedStudents_SubModule",
                                "StudentRecords_Module", "ManageStudents_SubModule", "PendingRequirements_SubModule",
                                "Billing_Module", "ManagePayments_SubModule", "BillingReport_SubModule",
                                "Academic_Module", "Fees_SubModule", "PaymentType_SubModule", "SectionsSchedule_SubModule", "GradeLevelSubjects_SubModule",
                                "Faculty_Module", "Teachers_SubModule", "UsersRoles_SubModule"};
            try
            {
                _connection.Open();
                foreach (string column in columns)
                {
                    string query = $"SELECT {column} FROM Roles WHERE RoleName = @RoleName";
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@RoleName", roleName);
                        map[column] = Convert.ToBoolean(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetUserRolePriviligesDictionary: {ex.Message}");
                return map;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetUserRolePriviligesDictionary: {ex.Message}");
                return map;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return map;
        }

        public void UpdateRolePrivileges(string roleName, Dictionary<string, bool> map)
        {
            try
            {
                _connection.Open();
                foreach (string column in map.Keys)
                {
                    string query = $"UPDATE Roles SET {column} = @Param WHERE RoleName = @RoleName";
                    using (SqlCommand command = new SqlCommand (query, _connection))
                    {
                        command.Parameters.AddWithValue("@Param", map[column]);
                        command.Parameters.AddWithValue("@RoleName", roleName);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateRolePrivileges: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateRolePrivileges: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}

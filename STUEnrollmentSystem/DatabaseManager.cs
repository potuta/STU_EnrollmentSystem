using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data.Common;

namespace STUEnrollmentSystem
{
    internal class DatabaseManager : ConnectionFactory
    {
        public DatabaseManager(string connectionString) : base(connectionString) { }
      
        public void DuplicateDatabase(string originalDbName, string newDbName)
        {
            string backupFilePath = $"{originalDbName}_backup.bak";

            // Step 1: Backup the original database to a file
            using (SqlConnection connection = new SqlConnection(_sourceConnectionString.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $@"BACKUP DATABASE [{originalDbName}] TO DISK = '{backupFilePath}' WITH INIT";
                    command.ExecuteNonQuery();
                }
            }

            // Step 2: Restore the backup to a new database
            using (SqlConnection connection = new SqlConnection(_sourceConnectionString.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $@"
                        RESTORE DATABASE [{newDbName}] 
                        FROM DISK = '{backupFilePath}' 
                        WITH MOVE '{originalDbName}' TO '{GetSqlDefaultDataPath()}\{newDbName}.mdf', 
                             MOVE '{originalDbName}_log' TO '{GetSqlDefaultDataPath()}\{newDbName}_log.ldf'";
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine($"Database '{originalDbName}' successfully duplicated as '{newDbName}'.");
        }

        public void DeleteDatabase(string databaseName)
        {
            // Form the connection to the master database to drop another database
            var masterConnectionString = new SqlConnectionStringBuilder(_sourceConnectionString.ConnectionString)
            {
                InitialCatalog = "master"
            }.ToString();

            using (SqlConnection connection = new SqlConnection(_sourceConnectionString.ConnectionString))
            {
                connection.Open();

                // Use a SQL command to drop the database
                string query = $@"
                    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    DROP DATABASE [{databaseName}];";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{databaseName}' deleted successfully.");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Error deleting database: {ex.Message}");
                    }
                }
            }
        }

        public string GetSqlDefaultDataPath()
        {
            string defaultDataPath = string.Empty;

            using (SqlConnection connection = new SqlConnection(_sourceConnectionString.ConnectionString))
            {
                connection.Open();

                // SQL to get the default SQL Server data directory
                string query = @"
                    DECLARE @default_data_path NVARCHAR(256);
                    SET @default_data_path = 
                        (SELECT physical_name FROM sys.master_files 
                        WHERE type = 0 AND database_id = 1);
                    SELECT @default_data_path;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    defaultDataPath = command.ExecuteScalar() as string;
                }
            }

            string defaultDataDirectory = Path.GetDirectoryName(defaultDataPath);
            return defaultDataDirectory;
        }

        public Dictionary<string, string> GetDatabaseConnectionStrings()
        {
            Dictionary<string, string> databases = new Dictionary<string, string>();
            List<string> databaseNamesList = new List<string>();

            string query = @"SELECT name
                            FROM sys.databases
                            WHERE (name NOT IN ('master', 'tempdb', 'model', 'msdb')) 
                            AND (name LIKE '%STU_DB%')";
            SqlCommand command = new SqlCommand(query, _sourceConnectionString);
            _sourceConnectionString.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int column = 0; column < reader.FieldCount; column++)
                    {
                        databaseNamesList.Add(reader.GetString(column));
                    }
                }
            }
            _sourceConnectionString.Close();

            foreach (string name in databaseNamesList)
            {
                databases[name] = GetNewDestinationString(name);
            }

            return databases;
        }

        public void UpdateDatabaseDataForSY(string schoolYear)
        {
            
        }
    }
}

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
using System.Data;

namespace STUEnrollmentSystem
{
    internal class DatabaseManager : ConnectionFactory
    {
        public DatabaseManager(string connectionString) : base(connectionString) { }
      
        public void DuplicateDatabase(string originalDbName, string newDbName)
        {
            try
            {
                LoggingService.LogInformation($"Database duplication attempt in DuplicateDatabase: OriginalDBname: {originalDbName} NewDBName: {newDbName}");
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
                LoggingService.LogInformation($"Database duplication successful in DuplicateDatabase: OriginalDBname: {originalDbName} NewDBName: {newDbName}");
            }
            catch (SqlException ex)
            {
                // Log SQL error (example: log to a file or monitoring system)
                Console.WriteLine($"SQL Error in DuplicateDatabase: {ex.Message}");
                // Optionally, handle specific SQL error codes here
                LoggingService.LogError($"SQL Error in DuplicateDatabase: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DuplicateDatabase: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DuplicateDatabase: {ex.Message}");
            }
            finally
            {
                if (_sourceConnectionString.State == ConnectionState.Open)
                    _sourceConnectionString.Close();
            }
        }

        public void DeleteDatabase(string databaseName)
        {
            try
            {
                LoggingService.LogInformation($"Database deletion attempt in DeleteDatabase: DBName: {databaseName}");
                using (SqlConnection connection = new SqlConnection(_sourceConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = $@"
                        ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                        DROP DATABASE [{databaseName}];";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{databaseName}' deleted successfully.");
                    }
                }
                LoggingService.LogInformation($"Database deletion succesful in DeleteDatabase: DBName: {databaseName}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in DeleteDatabase: {ex.Message}");
                LoggingService.LogError($"SQL Error in DeleteDatabase: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in DeleteDatabase: {ex.Message}");
                LoggingService.LogError($"Unexpected error in DeleteDatabase: {ex.Message}");
            }
            finally
            {
                if (_sourceConnectionString.State == ConnectionState.Open)
                    _sourceConnectionString.Close();
            }
        }

        public string GetSqlDefaultDataPath()
        {
            string defaultDataPath = string.Empty;
            string defaultDataDirectory = string.Empty;

            try
            {
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

                defaultDataDirectory = Path.GetDirectoryName(defaultDataPath);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetSqlDefaultDataPath: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetSqlDefaultDataPath: {ex.Message}");
            }
            finally
            {
                if (_sourceConnectionString.State == ConnectionState.Open)
                    _sourceConnectionString.Close();
            }

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

            try
            {
                _sourceConnectionString.Open();

                using (SqlCommand command = new SqlCommand(query, _sourceConnectionString))
                {
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
                }

                foreach (string name in databaseNamesList)
                {
                    databases[name] = GetNewDestinationString(name);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in GetDatabaseConnectionStrings: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in GetDatabaseConnectionStrings: {ex.Message}");
            }
            finally
            {
                if (_sourceConnectionString.State == ConnectionState.Open)
                    _sourceConnectionString.Close();
            }

            return databases;
        }

        public void UpdateDatabaseDataForSY(string schoolYear)
        {
            
        }
    }
}

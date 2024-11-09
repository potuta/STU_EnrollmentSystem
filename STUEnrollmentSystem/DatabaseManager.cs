using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace STUEnrollmentSystem
{
    internal class DatabaseManager
    {
        protected SqlConnection _sourceConnectionString;
        protected SqlConnection _destinationConnectionString;

        public DatabaseManager(string connectionString)
        {
            _sourceConnectionString = new SqlConnection(connectionString);
        }

        public void CreateDatabase(string newDatabaseName)
        {
            string query = $"CREATE DATABASE {newDatabaseName}";
            SqlCommand command = new SqlCommand(query, _sourceConnectionString);
            _sourceConnectionString.Open();
            command.ExecuteNonQuery();
            _sourceConnectionString.Close();
            SetDestinationString(newDatabaseName);
        }

        public void SetDestinationString(string databaseName)
        {
            string[] sourceConnectionStringArr = _sourceConnectionString.ConnectionString.Split(';');
            sourceConnectionStringArr[1] = $"Initial Catalog = {databaseName}";
            _destinationConnectionString.ConnectionString = string.Join(";", sourceConnectionStringArr);
        }

        public void CopyTableToDatabase(string sourceTableName, string destinationTableName)
        {
            DataTable tableData = new DataTable();
            string selectQuery = $"SELECT * FROM {sourceTableName}";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, _sourceConnectionString);
            adapter.Fill(tableData);

            string createTableQuery = GenerateCreateTableQuery(destinationTableName, tableData);
            SqlCommand command = new SqlCommand(createTableQuery, _destinationConnectionString);
            _destinationConnectionString.Open();
            command.ExecuteNonQuery();
            _destinationConnectionString.Close();

            SqlBulkCopy bulkCopy = new SqlBulkCopy(_destinationConnectionString);
            bulkCopy.DestinationTableName = destinationTableName;
            bulkCopy.WriteToServer(tableData);
        }

        private string GenerateCreateTableQuery(string tableName, DataTable tableSchema)
        {
            StringBuilder queryBuilder = new StringBuilder($"CREATE TABLE {tableName} (");

            foreach (DataColumn column in tableSchema.Columns)
            {
                queryBuilder.Append($"{column.ColumnName} {GetSqlDataType(column.DataType)}, ");
            }

            // Remove last comma and space, add closing parenthesis
            queryBuilder.Length -= 2;
            queryBuilder.Append(")");

            return queryBuilder.ToString();
        }

        private string GetSqlDataType(Type type)
        {
            var underlyingType = Nullable.GetUnderlyingType(type) ?? type;

            // Type mappings
            if (underlyingType == typeof(int)) return "INT";
            if (underlyingType == typeof(string)) return "VARCHAR(50)"; // Set default size for VARCHAR
            if (underlyingType == typeof(DateTime)) return "DATETIME";
            if (underlyingType == typeof(bool)) return "BIT";
            if (underlyingType == typeof(decimal)) return "DECIMAL(18,2)";
            if (underlyingType == typeof(float)) return "REAL";
            if (underlyingType == typeof(double)) return "FLOAT";
            if (underlyingType == typeof(byte)) return "TINYINT";
            if (underlyingType == typeof(long)) return "BIGINT";
            if (underlyingType == typeof(byte[])) return "VARBINARY(MAX)"; // Mapping for VARBINARY

            // Throw an exception for unsupported types
            throw new NotSupportedException($"The data type '{type.Name}' is not supported for SQL type mapping.");
        }
    }
}
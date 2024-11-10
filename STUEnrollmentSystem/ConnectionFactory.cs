using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class ConnectionFactory
    {
        protected SqlConnection _sourceConnectionString;
        public SqlConnection _destinationConnectionString;

        public ConnectionFactory(string connectionString)
        {
            _sourceConnectionString = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_sourceConnectionString.State == ConnectionState.Closed)
            {
                _sourceConnectionString.Open();
            }
        }

        public void CloseConnection()
        {
            if (_sourceConnectionString.State == ConnectionState.Open)
            {
                _sourceConnectionString.Close();
            }
        }

        public string GetConnectionString()
        {
            return _sourceConnectionString.ConnectionString;
        }

        public string GetNewDestinationString(string databaseName)
        {
            //string[] sourceConnectionStringArr = _sourceConnectionString.ConnectionString.Split(';');
            //sourceConnectionStringArr[1] = $"Initial Catalog = {databaseName}";
            //string destinationConnectionString = string.Join(";", sourceConnectionStringArr);
            //_destinationConnectionString = new SqlConnection(destinationConnectionString);

            var destinationConnectionString = new SqlConnectionStringBuilder(_sourceConnectionString.ConnectionString)
            {
                InitialCatalog = databaseName
            }.ToString();
            _destinationConnectionString = new SqlConnection(destinationConnectionString);

            return _destinationConnectionString.ConnectionString;
        }

        public static void UpdateConfigConnectionString(string name, string newConnectionString)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings.ConnectionStrings[name] != null)
            {
                config.ConnectionStrings.ConnectionStrings[name].ConnectionString = newConnectionString;
                config.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            }
            else
            {
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(name, newConnectionString, "System.Data.SqlClient"));
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}

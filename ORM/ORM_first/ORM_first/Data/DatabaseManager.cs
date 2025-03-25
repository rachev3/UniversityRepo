using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_first.Data
{
    internal class DatabaseManager : IDatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public bool DatabaseExists(string dbName)
        {
            using var connection = GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = @DbName";

            using var command = new SqlCommand(checkQuery, connection);
            command.Parameters.AddWithValue("@DbName", dbName);

            return (int)command.ExecuteScalar() > 0;
        }

        public void ExecuteNonQuery(string query)
        {
            using var connection = GetConnection();
            using var command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

}


using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_first.Data
{
    internal interface IDatabaseManager
    {
        public SqlConnection GetConnection();
        public bool DatabaseExists(string dbName);
        public void ExecuteNonQuery(string query);
    }
}

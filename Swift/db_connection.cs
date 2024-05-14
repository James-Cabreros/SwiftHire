using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_test
{
    internal class db_connection
    {
        public string dbconnect()
        {
            string conn = "server=localhost;user=root;password=;database=SwiftHire";
                return conn;
        }
    }
}

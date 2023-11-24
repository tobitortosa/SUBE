using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class DBConnection
    {
        public static MySqlConnection connectionMySql;
        public static MySqlCommand commandMySql;
        static DBConnection()
        {
            var mySqlStringConnection = @"Server=localhost;Database=sube;Uid=root;Pwd=;";
            connectionMySql = new MySqlConnection(mySqlStringConnection);

            commandMySql = new MySqlCommand();
            commandMySql.CommandType = System.Data.CommandType.Text;
            commandMySql.Connection = connectionMySql;
        }
    }
}

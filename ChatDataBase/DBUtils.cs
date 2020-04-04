using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChatDataBase
{
    public  class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "us-cdbr-iron-east-01.cleardb.net";
            int port = 3306;
            string database = "heroku_1e57249a9e2bdf7";
            string username = "b03ed90f473d6f";
            string password = "6edaf317";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}

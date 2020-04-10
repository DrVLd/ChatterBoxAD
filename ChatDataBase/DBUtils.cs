using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
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

        // Methode for SQL commands to login 
        public static User Login(string login, string password)
        {
            MySqlConnection dbcon = GetDBConnection();
            string query = "SELECT * FROM heroku_1e57249a9e2bdf7.user where login = '" + login + "' and password = '" + password + "'";
            dbcon.Open();
            var cmd = new MySqlCommand(query, dbcon);
            Console.WriteLine("Login data: " + query);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            User user = new User(dataReader.GetInt32(0),dataReader.GetString(1), dataReader.GetString(2));
            dbcon.Close();
            return user;
        }
        
        // Methode for registration of user
        public static void Registration(string login,string password)
        {
            MySqlConnection dbcon = GetDBConnection();
            string query = "INSERT INTO user(Login, Password) VALUES(@login, @password)"; 
            dbcon.Open();
            var cmd = new MySqlCommand(query, dbcon);
            Console.WriteLine("Inserted login data: " + query);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            dbcon.Close();
        }
    }
}

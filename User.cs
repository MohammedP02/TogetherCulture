using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture
{
    internal class User
    {
        // User class variables with auto-implemented getter and setter methods
        public int userID { get; private set; }
        public String username { get; private set; }
        public String password { get; private set; }
        public String role { get; private set; }

        // Constructor to initialize the 
        public User(int userID,String username,String password,String role) {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        //Empty Constructor
        public User() { 
        
        }

        public MySqlDataReader login(String username,String password) {
            MySqlDataReader results =null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected()) {
                string query = "SELECT * FROM user WHERE username=@param1 and password=@param2";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@param1", username);
                cmd.Parameters.AddWithValue("@param2", password);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    results = reader;
                }
                
            }

            return results;
        }

        public MySqlDataReader fetchUsers()
        {
            MySqlDataReader results = null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "SELECT * FROM user";
                var cmd = new MySqlCommand(query, connection.Connection);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    results = reader;
                }

            }

            return results;
        }

   
       




    }
}

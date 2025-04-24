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

   
        public void createProfile(int userID,int age,String name,String phonenumber,String location,List<String> interests)
        {
           
            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string queryProfile = "INSERT INTO profile(userID,name,age,location,phonenumber) VALUES(@userIDParam,@nameParam,@ageParam,@locationParam,@phonenumberParam)";
                var cmd = new MySqlCommand(queryProfile, connection.Connection);

                cmd.Parameters.AddWithValue("@userIDParam", userID);
                cmd.Parameters.AddWithValue("@nameParam", name);
                cmd.Parameters.AddWithValue("@ageParam", age);
                cmd.Parameters.AddWithValue("@locationParam", location);
                cmd.Parameters.AddWithValue("@phonenumberParam", phonenumber);

                var writer = cmd.ExecuteNonQuery();

                if (writer > 0)
                {
                    foreach (String interest in interests) {
                        string queryInterest = "INSERT INTO interests(userID,interestName) VALUES(@userIDParam,@interestParam)";
                        cmd = new MySqlCommand(queryInterest, connection.Connection);

                        cmd.Parameters.AddWithValue("@userIDParam", userID);
                        cmd.Parameters.AddWithValue("@interestParam", interest);

                        writer = cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile Created Successfully");
                }

            }
        }

        public void createProfile(int userID, int age, String name, String phonenumber, String location,int status, List<String> interests)
        {

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string queryProfile = "INSERT INTO profile(userID,name,age,location,phonenumber,status) VALUES(@userIDParam,@nameParam,@ageParam,@locationParam,@phonenumberParam,@statusParam)";
                var cmd = new MySqlCommand(queryProfile, connection.Connection);

                cmd.Parameters.AddWithValue("@userIDParam", userID);
                cmd.Parameters.AddWithValue("@nameParam", name);
                cmd.Parameters.AddWithValue("@ageParam", age);
                cmd.Parameters.AddWithValue("@locationParam", location);
                cmd.Parameters.AddWithValue("@phonenumberParam", phonenumber);
                cmd.Parameters.AddWithValue("@statusParam", status);

                var writer = cmd.ExecuteNonQuery();

                if (writer > 0)
                {
                    foreach (String interest in interests)
                    {
                        string queryInterest = "INSERT INTO interests(userID,interestName) VALUES(@userIDParam,@interestParam)";
                        cmd = new MySqlCommand(queryInterest, connection.Connection);

                        cmd.Parameters.AddWithValue("@userIDParam", userID);
                        cmd.Parameters.AddWithValue("@interestParam", interest);

                        writer = cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile Created Successfully");
                }

            }
        }

        public MySqlDataReader fetchProfile(int userID)
        {
            MySqlDataReader results = null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "SELECT * FROM profile WHERE userID=@param1";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@param1", userID);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    results = reader;
                }

            }

            return results;
        }

        public MySqlDataReader fetchProfileByName(String search)
        {
            MySqlDataReader results = null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "SELECT * FROM profile WHERE name LIKE @p1 @param1 @p2 ";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@p1", "%");
                cmd.Parameters.AddWithValue("@param1",search);
                cmd.Parameters.AddWithValue("@p2", "%");

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    results = reader;
                }

            }

            return results;
        }

        public MySqlDataReader fetchInterests(int userID)
        {
            MySqlDataReader results = null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "SELECT * FROM interests WHERE userID=@param1";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@param1", userID);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    results = reader;
                }

            }

            return results;
        }

        public void updateProfile(int userID, int age, String name, String phonenumber, String location, List<String> interests)
        {

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string queryUpdate= "UPDATE profile SET name=@nameParam,age=@ageParam,location=@locationParam,phonenumber=@phonenumberParam WHERE userID=@userIDParam";
                var cmd = new MySqlCommand(queryUpdate, connection.Connection);

                cmd.Parameters.AddWithValue("@nameParam", name);
                cmd.Parameters.AddWithValue("@ageParam", age);
                cmd.Parameters.AddWithValue("@locationParam", location);
                cmd.Parameters.AddWithValue("@phonenumberParam", phonenumber);
                cmd.Parameters.AddWithValue("@userIDParam", userID);


                var writer = cmd.ExecuteNonQuery();

               
                string queryDelete = "DELETE FROM interests WHERE userID=@userIDParam";
                cmd = new MySqlCommand(queryDelete, connection.Connection);

                cmd.Parameters.AddWithValue("@userIDParam", userID);
                writer = cmd.ExecuteNonQuery();

                if (writer > 0)
                {
                    foreach (String interest in interests)
                    {
                        string queryInterest = "INSERT INTO interests(userID,interestName) VALUES(@userIDParam,@interestParam)";
                        cmd = new MySqlCommand(queryInterest, connection.Connection);

                        cmd.Parameters.AddWithValue("@userIDParam", userID);
                        cmd.Parameters.AddWithValue("@interestParam", interest);

                        writer = cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile Updated Successfully");
                }

            }
        }

        public bool deleteInterests(int userID)
        {
            bool del = false;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "DELETE FROM interests WHERE userID=@param1";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@param1", userID);

                var writer = cmd.ExecuteNonQuery();

                if (writer>0)
                {
                    del = true;
                }

            }

            return del;
        }




    }
}

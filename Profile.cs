using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TogetherCulture
{
    internal class Profile
    {
        int userID { get; set; }
        int age { get; set; }
        
        String name { get; set; }
        
        String phonenumber { get; set; }
        
        String location { get; set; }
        
        List<String> interests { get; set; }
        public Profile(int userID, int age, String name, String phonenumber, String location, List<String> interests) { 
        
        }
        public Profile()
        {

        }
        public void createProfile(int userID, int age, String name, String phonenumber, String location, List<String> interests)
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

        public void createProfile(int userID, int age, String name, String phonenumber, String location, int status, List<String> interests)
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
                cmd.Parameters.AddWithValue("@param1", search);
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
                string queryUpdate = "UPDATE profile SET name=@nameParam,age=@ageParam,location=@locationParam,phonenumber=@phonenumberParam WHERE userID=@userIDParam";
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

        public void authorize(int userID)
        {

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string queryUpdate = "UPDATE profile SET status=@statusParam WHERE userID=@userIDParam";
                var cmd = new MySqlCommand(queryUpdate, connection.Connection);

                cmd.Parameters.AddWithValue("@statusParam", 1);
                cmd.Parameters.AddWithValue("@userIDParam", userID);


                var writer = cmd.ExecuteNonQuery();

                if (writer > 0)
                {
                    MessageBox.Show("Profile Authorized Successfully");
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

                if (writer > 0)
                {
                    del = true;
                }

            }

            return del;
        }
    }
}

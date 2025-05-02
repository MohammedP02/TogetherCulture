using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TogetherCulture
{
    public class UserTest
    {

        [Fact] // This attribute marks this method as a test.
        public void login()
        {
            MySqlDataReader results = null;

            var connection = new DatabaseConnector();

            connection.Server = "localhost";
            connection.DatabaseName = "togetherculture";
            connection.UserName = "root";
            connection.Password = "";

            if (connection.Connected())
            {
                string query = "SELECT * FROM user WHERE username=@param1 and password=@param2";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@param1", "admin");
                cmd.Parameters.AddWithValue("@param2", "1234");

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    results = reader;
                }

            }

            User user = new User();

            // Assert
            Assert.Equal(results, user.login("admin","1234")); // Check if the result is as expected.
        }

    }
}

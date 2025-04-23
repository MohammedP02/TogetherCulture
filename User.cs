using System;
using System.Collections.Generic;
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

        public void login() { 
        
        
        }

        


    }
}

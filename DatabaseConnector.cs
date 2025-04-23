using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TogetherCulture
{
    internal class DatabaseConnector
    {
        var dbCon = DBConnection.Instance();
        dbCon.Server = "YourServer";
dbCon.DatabaseName = "YourDatabase";
dbCon.UserName = "YourUsername";
dbCon.Password = "YourPassword";
if (dbCon.IsConnect())
    }
}

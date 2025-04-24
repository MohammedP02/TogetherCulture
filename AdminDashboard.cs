using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TogetherCulture
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            // Fetch all users
            User user = new User();
            MySqlDataReader allUsers=user.fetchUsers();

            if (allUsers != null)
            {
                using (allUsers)
                {
                    foreach (DbDataRecord record in allUsers)
                    {

                        int userID = record.GetInt32(0);

                        var connection = new DatabaseConnector();

                        connection.Server = "localhost";
                        connection.DatabaseName = "togetherculture";
                        connection.UserName = "root";
                        connection.Password = "";

                        if (connection.Connected() && record.GetString(3)!="admin")
                        {
                            string query = "SELECT * FROM profile where userID=@userIDParam";
                            var cmd = new MySqlCommand(query, connection.Connection);
                            cmd.Parameters.AddWithValue("@userIDParam", userID);

                            var reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                String results = "";
                            }
                            else
                            {
                                string userString = record.GetInt32(0).ToString() + "-" + record.GetString(1);
                                comboUsers.Items.Add(userString);
                            }

                        }

                        
                        
                    }
                }

            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            int userID = Int32.Parse(comboUsers.SelectedItem.ToString().Split("-")[0]);

            int age = Int32.Parse(txtAge.Text);
            String name = txtName.Text;
            String phonenumber = txtNumber.Text;
            String location = txtLocation.Text;

            String status = comboStatus.SelectedItem.ToString();
            int statusInt = 0;

            if (status.Contains("Authorized")) {
                statusInt = 1;
            }

            List<String> interests = new List<string>();

            if (chkCaring.Checked)
            {
                interests.Add("Caring");
            }

            if (chkCreating.Checked)
            {
                interests.Add("Creating");
            }

            if (chkExperiencing.Checked)
            {
                interests.Add("Experiencing");
            }

            if (chkSharing.Checked)
            {
                interests.Add("Sharing");
            }

            if (chkWorking.Checked)
            {
                interests.Add("Working");
            }

            User user = new User();
            user.createProfile(userID, age, name, phonenumber, location,statusInt, interests);

            comboUsers.Text = "";
            comboStatus.Text = "";
            txtAge.Text = "";
            txtName.Text = "";
            txtNumber.Text = "";
            txtLocation.Text = "";

            chkCaring.Checked = false;
            chkCreating.Checked = false;
            chkExperiencing.Checked = false;
            chkSharing.Checked = false;
            chkWorking.Checked = false;
          
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TogetherCulture
{
    public partial class UserProfilePage : Form
    {
        public UserProfilePage(MySqlDataReader profile, Int32 userID, MySqlDataReader interests)
        {
            InitializeComponent();
            txtUserID.Text = userID.ToString();

            if (profile != null)
            {
                using (profile)
                {
                    foreach (DbDataRecord record in profile)
                    {
                        txtName.Text = record.GetString(2);
                        txtAge.Text = record.GetInt32(3).ToString();
                        txtLocation.Text = record.GetString(4);
                        txtNumber.Text = record.GetString(5);

                        String status = "";

                        if (record.GetInt32(6) == 1)
                        {
                            status = "Authorized";
                        }
                        else
                        {
                            status = "Pending Authorization";

                        }

                        txtStatus.Text = status;
                    }
                }

                if (interests != null)
                {
                    using (interests)
                    {
                        foreach (DbDataRecord record in interests)
                        {
                            String interest = record.GetString(1);
                            if (interest == "Sharing")
                            {
                                chkSharing.Checked = true;
                            }
                            else if (interest == "Caring")
                            {
                                chkCaring.Checked = true;
                            }
                            else if (interest == "Creating")
                            {
                                chkCreating.Checked = true;
                            }
                            else if (interest == "Experiencing")
                            {
                                chkExperiencing.Checked = true;
                            }
                            else if (interest == "Working")
                            {
                                chkWorking.Checked = true;
                            }
                        }

                    }
                }
                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void UserProfilePage_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(txtUserID.Text);
            int age = Int32.Parse(txtAge.Text);
            String name = txtName.Text;
            String phonenumber = txtNumber.Text;
            String location = txtLocation.Text;

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
            user.createProfile(userID, age, name, phonenumber, location, interests);

            txtUserID.Text = "";
            txtAge.Text = "";
            txtName.Text = "";
            txtNumber.Text = "";
            txtLocation.Text = "";

            chkCaring.Checked = false;
            chkCreating.Checked = false;
            chkExperiencing.Checked = false;
            chkSharing.Checked = false;
            chkWorking.Checked = false;

            MySqlDataReader profile = user.fetchProfile(userID);
            MySqlDataReader interest = user.fetchInterests(userID);
            this.Hide();
            UserProfilePage loadProfile = new UserProfilePage(profile, userID, interest);
            loadProfile.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(txtUserID.Text);
            int age = Int32.Parse(txtAge.Text);
            String name = txtName.Text;
            String phonenumber = txtNumber.Text;
            String location = txtLocation.Text;

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
            user.updateProfile(userID, age, name, phonenumber, location, interests);

            MySqlDataReader profile = user.fetchProfile(userID);
            MySqlDataReader interest = user.fetchInterests(userID);
            this.Hide();
            UserProfilePage loadProfile = new UserProfilePage(profile, userID, interest);
            loadProfile.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

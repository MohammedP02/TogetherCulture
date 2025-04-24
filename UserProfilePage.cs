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

namespace TogetherCulture
{
    public partial class UserProfilePage : Form
    {
        public UserProfilePage(MySqlDataReader profile,Int32 userID, MySqlDataReader interests)
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

                        String status="";

                        if (record.GetInt32(6) == 1)
                        {
                            status = "Authorized";
                        }
                        else {
                            status = "Pending Authorization";
                            btnUpdate.Enabled = false;
                        }

                        txtStatus.Text = status;
                    }
                }

                if (interests!=null)
                {
                    using (interests) {
                        foreach (DbDataRecord record in interests)
                        {
                            String interest=record.GetString(1);
                            if (interest=="Sharing") {
                                chkSharing.Checked = true;
                            }else if (interest == "Caring")
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
            }
            else { 
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
    }
}

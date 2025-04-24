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
                        txtAge.Text = record.GetString(3);
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

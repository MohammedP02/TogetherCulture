using MySql.Data.MySqlClient;
using System.Data.Common;

namespace TogetherCulture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            User user = new User();
            MySqlDataReader queryResults = user.login(username, password);

            if (queryResults == null)
            {
                MessageBox.Show("Incorrect Username or Password. Try Again");
            }
            else
            {
                int userID = 0;
                //get the role,userID and redirect to the user profile or admin dashboard
                using (queryResults)
                {
                    while (queryResults.Read())
                    {
                        String role = queryResults.GetString(3);
                        userID = queryResults.GetInt32(0);
                        if (role == "user")
                        {
                            this.Hide();
                            //fetch the profile
                            MySqlDataReader profile = user.fetchProfile(userID);
                            MySqlDataReader interests = user.fetchInterests(userID);

                            UserProfilePage page = new UserProfilePage(profile, userID, interests);
                            page.Show();
                        }
                        else
                        {
                            this.Hide();
                            AdminDashboard dashboard = new AdminDashboard();
                            dashboard.Show();
                        }
                    }
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

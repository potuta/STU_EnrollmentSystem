using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STUEnrollmentSystem
{
    public partial class Login : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public Login()
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void confirmUserLogin(string userID, string username, string password)
        {
            try
            {
                STU_Command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password", STU_DB_Connection);
                STU_Command.Parameters.AddWithValue("@UserID", userID);
                STU_Command.Parameters.AddWithValue("@Username", username);
                STU_Command.Parameters.AddWithValue("@Password", password);

                STU_DB_Connection.Open();
                bool isUserVerified = STU_Command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
                STU_DB_Connection.Close();

                if (isUserVerified == true)
                {
                    STU_Dashboard STU = new STU_Dashboard(userID, username, password);
                    STU.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            catch (NullReferenceException nre)
            {
                STU_DB_Connection.Close();
                MessageBox.Show("User not found");
                return;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!userIDTextBox.Text.Equals(string.Empty) && !usernameTextBox.Text.Equals(string.Empty) && !passwordTextBox.Text.Equals(string.Empty))
            {
                confirmUserLogin(userIDTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
            }
            else
            {
                return;
            }
        }
    }
}

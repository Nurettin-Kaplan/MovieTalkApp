using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTalkApp
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            signInScreen signIn = new signInScreen();
            signIn.Owner = this;
            this.Hide();
            signIn.Show();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginScreen adminLogin = new AdminLoginScreen();
            adminLogin.Owner = this;
            this.Hide();
            adminLogin.Show();
        }

        private void LinkLblRefPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshPassword refreshPassword = new RefreshPassword();
            refreshPassword.Owner = this;
            this.Hide();
            refreshPassword.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select Username, UserPassword, Author from Users WHERE Username=@username AND UserPassword=@password AND Author=@author";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", TxtUsername.Text);
            command.Parameters.AddWithValue("@password", TxtPassword.Text);
            command.Parameters.AddWithValue("@author", 0);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) // girilen veriler db'de var mı???
            {
                Application app = new Application(TxtUsername.Text);
                app.Show();
                this.Hide();
            }
            else
            {
                LblInfo.Text = "Girdiğiniz kullanıcı adı veya şifre yanlış.";
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                TxtUsername.Focus();    // imleci konumlandırıyor.
            }

            connection.Close();
        }

        private void PBoxWievPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '\0';
        }

        private void PBoxWievPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '●';
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

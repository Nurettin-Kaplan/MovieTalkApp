using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using System.Data.SqlClient;

namespace MovieTalkApp
{
    public partial class NewPassword : Form
    {
        public string username = "";
        public NewPassword(string data)
        {
            InitializeComponent();
            username = data;
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        private void BtnAccept_Click(object sender, EventArgs e)
        {

            if (TxtPassword.Text == TxtPassword2.Text)
            {
                connection.Open();

                string query = "update Users set UserPassword=@newPassword where Username=@username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPassword", TxtPassword.Text);
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Şifre güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                TxtPassword.Text = "";
                TxtPassword2.Text = "";
                TxtPassword.Focus();
                LblInfo.Text = "Girilen şifreler birbiri ile uyuşmuyor.";
            }
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            string imagePath = "";
            connection.Open();

            string query = "select ProfilePicture from Users where Username=@username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                imagePath = reader["ProfilePicture"].ToString();
            }
            reader.Close();
            connection.Close();

            pictureBox2.ImageLocation = imagePath;
            LblUsername.Text = username;
        }

        private void PBoxWievPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '\0';
        }

        private void PBoxWievPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '●';
        }

        private void PBoxWievPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword2.PasswordChar = '\0';
        }

        private void PBoxWievPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword2.PasswordChar = '●';
        }
    }
}

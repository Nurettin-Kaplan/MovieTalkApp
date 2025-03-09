using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Azure.Identity;

namespace MovieTalkApp
{
    public partial class RefreshPassword : Form
    {

        public RefreshPassword()
        {
            InitializeComponent();
        }

        Random rnd = new Random();      // random sınıfından bir nesne türettim
        int randomNumber = 0;           // randomNumber değişkeni oluşturup varsayılan değerine 0 atadım
        string username = "";

        private void RefreshPassword_Load(object sender, EventArgs e)
        {
            randomNumber = rnd.Next(1000, 9999);
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        public void SendMail()
        {
            string fromAddress = "movietalkapplication@gmail.com";
            string toAddress = TxtEmail.Text;
            string subject = "Şifre Yenileme";
            string body = TxtUsername.Text + " kullanıcı adlı hesabınız için şifre yenileme kodu: " + randomNumber;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromAddress);
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("movietalkapplication@gmail.com", "dcll pmxf zhwp pfhm");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void RefreshPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnSendCode_Click(object sender, EventArgs e)
        {
            username = TxtUsername.Text;
            connection.Open();
            string query = "select Username, Email, Phone from Users WHERE Username=@username AND Email=@email AND Phone=@phone";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", TxtUsername.Text);
            command.Parameters.AddWithValue("@email", TxtEmail.Text);
            command.Parameters.AddWithValue("@phone", TxtPhone.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) // girilen veriler db'de var mı???
            {
                randomNumber = rnd.Next(1000, 9999);
                SendMail();
                MailCodeScreen mailCode = new MailCodeScreen(username, randomNumber);
                mailCode.Owner = this;
                mailCode.Show();
            }
            else
            {
                LblInfo.Text = "Girdiğiniz bilgilerle eşleşen kullanıcı bulunamadı.";
                TxtUsername.Text = "";
                TxtEmail.Text = "";
                TxtPhone.Text = "";
                TxtUsername.Focus();    // imleci konumlandırıyor.
            }

            connection.Close();
        }
    }
}

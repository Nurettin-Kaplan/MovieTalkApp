using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTalkApp
{
    public partial class MailCodeScreen : Form
    {
        private int rand = 0;
        public string username = "";
        public MailCodeScreen(string data, int randomNumber)
        {
            InitializeComponent();
            rand = randomNumber;
            username = data;
        }

        private int remainingTime = 120; // 2 dakika = 120 saniye

        private void MailCodeScreen_Load(object sender, EventArgs e)
        {
            remainingTime = 120; // Süreyi sıfırla
            LblCountdown.Text = "02:00"; // Label'ı sıfırla
            timer1.Enabled = true; // Timer'ı başlat
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(TxtCode.Text) == rand)
            {
                NewPassword newPass = new NewPassword(username);
                newPass.Show();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girilen kod yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                int minutes = remainingTime / 60;
                int seconds = remainingTime % 60;

                LblCountdown.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                timer1.Enabled = false; // Timer'ı durdur
                LblCountdown.Text = "Süre doldu!";
                this.Close();
            }
        }
    }
}

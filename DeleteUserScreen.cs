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
using Microsoft.VisualBasic.ApplicationServices;

namespace MovieTalkApp
{
    public partial class DeleteUserScreen : Form
    {
        public DeleteUserScreen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query = "select * from Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.Open();
            adapter.Fill(table);

            DGViewUsers.DataSource = table;

            connection.Close();
        }

        private void DGViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGViewUsers.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                TxtUserID.Text = row.Cells["UserID"].Value.ToString();
            }
        }

        private void DeleteUserScreen_Load(object sender, EventArgs e)
        {
            DGViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGViewUsers.MultiSelect = false;
        }

        private void BtnToDelete_Click(object sender, EventArgs e)
        {
            if (TxtUserID.Text == "")
            {
                MessageBox.Show("Silinecek olan kullanıcının ID alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string query = "delete from Users where UserID=@userID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", TxtUserID.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

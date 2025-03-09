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
    public partial class DeleteMovieScreen : Form
    {
        public DeleteMovieScreen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query = "select * from Movies";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.Open();
            adapter.Fill(table);

            DGViewMovies.DataSource = table;

            connection.Close();
        }

        private void DeleteMovieScreen_Load(object sender, EventArgs e)
        {
            DGViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGViewMovies.MultiSelect = false;
        }

        private void DGViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGViewMovies.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                TxtMovieID.Text = row.Cells["MovieID"].Value.ToString();
            }
        }

        private void BtnToDelete_Click(object sender, EventArgs e)
        {
            if (TxtMovieID.Text == "")
            {
                MessageBox.Show("Silinecek olan filmin ID alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string query = "delete from Movies where MovieID=@movieid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@movieid", TxtMovieID.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

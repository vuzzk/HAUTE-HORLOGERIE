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

namespace HAUTE_HORLOGERIE
{
    public partial class AdminUsers : Form
    {
        DataTable dt_korisnici = new DataTable();


        public AdminUsers()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMain main = new AdminMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void GridPopulate()
        {
            string naredba = "select * from OstaliKorisnici";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_korisnici = new DataTable();
            adapter.Fill(dt_korisnici);
            dataGridView.DataSource = dt_korisnici;
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            GridPopulate();
        }
    }
}

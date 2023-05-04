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
        DataTable dt_uloge = new DataTable();
        int index = 0;

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

        private void FieldsPopulate(int index)
        {
            string kat;
            string naredba = "select * from OstaliKorisnici";
            string naredba1 = "select * from UlogeKorisnika";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            SqlDataAdapter adapterKategorije = new SqlDataAdapter(naredba1, konekcija);
            dt_korisnici = new DataTable();
            dt_uloge = new DataTable();
            adapter.Fill(dt_korisnici);
            adapterKategorije.Fill(dt_uloge);
            roleComboBox.DataSource = dt_uloge;
            roleComboBox.ValueMember = "uloga_korisnika_id";
            roleComboBox.DisplayMember = "naziv";

            nameTextBox.Text = dt_korisnici.Rows[index][0].ToString();
            userTextBox.Text = dt_korisnici.Rows[index][1].ToString();
            mailTextBox.Text = dt_korisnici.Rows[index][2].ToString();
            countryTextBox.Text = dt_korisnici.Rows[index][3].ToString();
            cityTextBox.Text = dt_korisnici.Rows[index][4].ToString();
            zipTextBox.Text = dt_korisnici.Rows[index][5].ToString();
            adressTextBox.Text = dt_korisnici.Rows[index][5].ToString();
            kat = dt_korisnici.Rows[index][6].ToString();
            //string naredba2 = "select kategorija_id from Kategorije where ime = " + kat;
            //SqlCommand komanda2 = new SqlCommand(naredba2, konekcija);
            //konekcija.Open();
            //roleComboBox.SelectedValue = (int)komanda2.ExecuteScalar();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            GridPopulate();
            FieldsPopulate(index);
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            index = (int)dataGridView.CurrentCell.RowIndex;
            FieldsPopulate(index);
        }

        private void dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = (int)dataGridView.CurrentCell.RowIndex;
            FieldsPopulate(index);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' or username like '%{0}%' ", searchTextBox.Text);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

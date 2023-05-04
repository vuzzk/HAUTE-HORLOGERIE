using HAUTE_HORLOGERIE.Konekcija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAUTE_HORLOGERIE
{
    public partial class AdminProducts : Form
    {
        DataTable dt_proizvodi = new DataTable();
        DataTable dt_kategorije = new DataTable();
        int index = 0;

        public AdminProducts()
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
            string naredba = "select * from PregledProizvoda";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_proizvodi = new DataTable();
            adapter.Fill(dt_proizvodi);
            dataGridView.DataSource = dt_proizvodi;
        }

        private void FieldsPopulate(int index)
        {
            string kat;
            string naredba = "select * from PregledProizvoda";
            string naredba1 = "select * from Kategorije";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            SqlDataAdapter adapterKategorije = new SqlDataAdapter(naredba1, konekcija);
            dt_proizvodi = new DataTable();
            dt_kategorije = new DataTable();
            adapter.Fill(dt_proizvodi);
            adapterKategorije.Fill(dt_kategorije);
            catComboBox.DataSource = dt_kategorije;
            catComboBox.ValueMember = "kategorija_id";
            catComboBox.DisplayMember = "ime";

            nameTextBox.Text = dt_proizvodi.Rows[index][0].ToString();
            skuTextBox.Text = dt_proizvodi.Rows[index][1].ToString();
            priceTextBox.Text = dt_proizvodi.Rows[index][2].ToString();
            quantityNumericUpDown.Value = (int)dt_proizvodi.Rows[index][3];
            manufacturerTextBox.Text = dt_proizvodi.Rows[index][4].ToString();
            descTextBox.Text = dt_proizvodi.Rows[index][5].ToString();
            kat = dt_proizvodi.Rows[index][6].ToString();
            string naredba2 = "select kategorija_id from Kategorije where ime = " + kat;
            SqlCommand komanda2 = new SqlCommand(naredba2, konekcija);
            //konekcija.Open();
            //catComboBox.SelectedValue = (int)komanda2.ExecuteScalar();
        }


        private void AdminProducts_Load(object sender, EventArgs e)
        {
            GridPopulate();
            FieldsPopulate(index);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = (int)dataGridView.CurrentCell.RowIndex;
            FieldsPopulate(index);
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            index = (int)dataGridView.CurrentCell.RowIndex;
            FieldsPopulate(index);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' or sku like '%{0}%'", searchTextBox.Text);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' or sku like '%{0}%'", searchTextBox.Text);
        }
    }
}

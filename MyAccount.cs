using HAUTE_HORLOGERIE.Konekcija;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HAUTE_HORLOGERIE
{
    public partial class MyAccount : Form
    {
        int user;
        DataTable tabela;

        public MyAccount(int u)
        {
            InitializeComponent();
            user = u;
            tabela = new DataTable();
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Korisnici WHERE korisnik_id = "+ Convert.ToString(user), konekcija);
            adapter.Fill(tabela);
            Populate();

        }

        private void Populate()
        {
            nameTextBox.Text = tabela.Rows[0][1].ToString();
            surnameTextBox.Text = tabela.Rows[0][2].ToString();
            passwordTextBox.Text = tabela.Rows[0][4].ToString();
            mailTextBox.Text = tabela.Rows[0][5].ToString();
            countryTextBox.Text = tabela.Rows[0][6].ToString();
            cityTextBox.Text = tabela.Rows[0][7].ToString();
            zipTextBox.Text = tabela.Rows[0][8].ToString();
            adressTextBox.Text = tabela.Rows[0][9].ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(user);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;
            updateButton.Visible = true;
            nameTextBox.Enabled = true;
            surnameTextBox.Enabled = true;
            countryTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            zipTextBox.Enabled = true;
            adressTextBox.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE Korisnici SET ";
            naredba = naredba + "ime = '" + nameTextBox.Text + "',";
            naredba = naredba + "prezime = '" + surnameTextBox.Text + "',";
            naredba = naredba + "drzava = '" + countryTextBox.Text + "',";
            naredba = naredba + "grad = '" + cityTextBox.Text + "',";
            naredba = naredba + "postanski_br = '" + zipTextBox.Text + "',";
            naredba = naredba + "adresa = '" + adressTextBox.Text + "'";
            naredba = naredba + " WHERE korisnik_id = " + Convert.ToString(user);
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception greska) 
            {
                MessageBox.Show("There was an error, not all data have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabela = new DataTable();
            konekcija.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Korisnici WHERE korisnik_id = " + Convert.ToString(user), konekcija);
            adapter.Fill(tabela);
            Populate();
            MessageBox.Show("Account updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateButton.Enabled = false;
            updateButton.Visible = false;
        }
    }
}

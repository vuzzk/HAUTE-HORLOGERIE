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
    public partial class Signup : Form
    {
        int u;
        public Signup()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            int provera = 0;
            string naredba = "Insert Into Korisnici Values('";
            naredba += nameTextBox.Text + "', '";
            naredba += surnameTextBox.Text + "', '";
            naredba += userTextBox.Text + "', '";
            naredba += passwordTextBox.Text + "', '";
            naredba += mailTextBox.Text + "', '";
            naredba += countryTextBox.Text + "', '";
            naredba += cityTextBox.Text + "', '";
            naredba += zipTextBox.Text + "', '";
            naredba += adressTextBox.Text + "', '";
            naredba += 3 + ")";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            string naredba1 = "select COUNT(*) from Korisnici ";
            naredba1 += "where email = '" + mailTextBox.Text + "'";
            SqlCommand komanda1 = new SqlCommand(naredba1, konekcija);
            konekcija.Open();
            provera = (int)komanda1.ExecuteScalar();
            konekcija.Close();
            if (provera == 0)
            {
                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Account updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection konekcija1 = Konekcija.Konekcija.Konektuj();
                    string naredba2 = "select korisnik_id from Korisnici ";
                    naredba2 += "where email = '" + mailTextBox.Text + "'";
                    SqlCommand komanda2 = new SqlCommand(naredba2, konekcija1);
                    konekcija1.Open();
                    u = (int)komanda2.ExecuteNonQuery();
                    konekcija1.Close();
                    HomeForm home = new HomeForm(u);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show("There was an error, check entered data again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There was an error, entered mail already exists, check entered data again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}

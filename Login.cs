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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int provera = 0;
            int uloga = 0;
            int user;
            string naredba = "select COUNT(*) from Korisnici ";
            naredba += "where email = '" + mailTextBox.Text + "'";
            SqlConnection konekcija = Konekcija.Konekcija.Konektuj();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            konekcija.Open();
            provera = (int)komanda.ExecuteScalar();
            konekcija.Close();
            if (provera == 1)
            {
                string naredba1 = "select uloga_korisnika_id from Korisnici ";
                naredba1 += "where email = '" + mailTextBox.Text + "'";
                string naredba2 = "select korisnik_id from Korisnici ";
                naredba2 += "where email = '" + mailTextBox.Text + "'";
                SqlConnection konekcija1 = Konekcija.Konekcija.Konektuj();
                SqlCommand komanda1 = new SqlCommand(naredba1, konekcija1);
                SqlCommand komanda2 = new SqlCommand(naredba2, konekcija1);
                konekcija1.Open();
                uloga = (int)komanda1.ExecuteScalar();
                user = (int)komanda2.ExecuteScalar();
                konekcija1.Close();
                if (uloga == 3)
                {
                    HomeForm home = new HomeForm(user);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    AdminMain main = new AdminMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("There was an error, that account do not exist, check entered data again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0';
                showPasswordButton.ImageIndex = 1;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                showPasswordButton.ImageIndex = 0;
            }
        }
    }
}

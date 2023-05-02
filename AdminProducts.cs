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
            dataGridView.AllowUserToAddRows = false;
        }


        private void AdminProducts_Load(object sender, EventArgs e)
        {
            GridPopulate();
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                descTextBox.Text = dataGridView.CurrentCell.Value.ToString();
            }
            else
            {
                descTextBox.Text = "Click cell in DESCRIPTION column to see full description.";
            }

            /*
             int opis_id = 1;
                string cell = dataGridView.CurrentCell.Value.ToString();
                string naredba1 = "select opis_id from Proizvodi where ime like '" + cell + "'" +
                                                                " or sifra like '" + cell + "'" +
                                                                " or cena like '" + cell + "'" +
                                                                " or kolicina like '" + cell + "'" +
                                                                " or proizvodjac like '" + cell + "'" +
                                                                " or kategorija_id like '" + cell + "'";    

                    SqlConnection konekcija1 = Konekcija.Konekcija.Konektuj();
                    SqlCommand komanda1 = new SqlCommand(naredba1, konekcija1);
                    konekcija1.Open();
                    opis_id = (int)komanda1.ExecuteScalar();
                    string naredba2 = "select tekst from Opisi where opis_id = " + Convert.ToString(opis_id);
                    SqlCommand komanda2 = new SqlCommand(naredba2, konekcija1);
                    descTextBox.Text = (string)komanda2.ExecuteScalar();
                    konekcija1.Close();
            */
        }
    }
}

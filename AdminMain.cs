using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAUTE_HORLOGERIE
{
    public partial class AdminMain : Form
    {
        int u = 4;
        public AdminMain()
        {
            InitializeComponent();
        }

        private void buttonSeeStore_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(u);
            home.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(u);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            AdminProducts products = new AdminProducts();
            this.Hide();
            products.ShowDialog();
            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AdminUsers users = new AdminUsers();
            this.Hide();
            users.ShowDialog();
            this.Close();
        }
    }
}

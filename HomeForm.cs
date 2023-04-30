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
    public partial class HomeForm : Form
    {
        int u;

        public HomeForm(int user)
        {
            u = user;
            InitializeComponent();
        }

        private void aboutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            MyAccount user = new MyAccount(u);
            this.Hide();
            user.ShowDialog();
            this.Close();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

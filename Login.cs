﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AdminMain home = new AdminMain();
            this.Hide();
            home.ShowDialog();
            this.Close();
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
    }
}

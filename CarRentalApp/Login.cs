using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var usernaem = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                //Add db connection then use this
                //var user = _db.User.FindByName(usernaem);
                if (usernaem == null)
                {
                    MessageBox.Show("Please proveide a valid credenteials");
                }
                else
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again ");

                //throw;
            }
        }
    }
}

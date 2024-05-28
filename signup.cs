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
using Productivity_Nexus.Helpers;

namespace Productivity_Nexus
{
    public partial class signup : Form
    {
        DbHelper db = new DbHelper();
        public signup()
        {
            InitializeComponent();
            guna2TextBox2.PasswordChar = '*'; // You can use any character such as '*'


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string password = guna2TextBox2.Text;

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                string query = $"INSERT INTO userlist VALUES('{guna2TextBox1.Text.Replace("'", "''")}', '{password.Replace("'", "''")}')";

                try
                {
                    db.InsertRow(query);
                    this.Hide();
                    Main_form main_form = new Main_form();
                    main_form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 8 characters long, contain at least one uppercase letter, and one special character.");
            }
        }



    }
}

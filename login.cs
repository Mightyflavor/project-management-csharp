using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productivity_Nexus.Helpers;

namespace Productivity_Nexus
{
    public partial class login : Form
    {
        DbHelper db = new DbHelper();
        public login()
        {
            InitializeComponent();
            guna2TextBox2.PasswordChar = '*'; // You can use any character such as '*'


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //close this form and open the form Main_form
           
            if(db.userAuth(guna2TextBox1.Text, guna2TextBox2.Text))
            {
                this.Hide();
                Main_form main_form = new Main_form();
                main_form.Show();
                
            }
            else
            {

                MessageBox.Show("error");
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        }
    }
}

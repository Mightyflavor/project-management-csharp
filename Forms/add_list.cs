using Guna.UI2.WinForms;
using Productivity_Nexus.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Nexus.Forms
{
    public partial class add_list : UserControl
    {
        DbHelper db;
        public event EventHandler RequestPanelBack;  // Define an event

        public add_list()
        {
            InitializeComponent();
            db = new DbHelper();
            this.guna2ImageButton4.Click += guna2ImageButton4_Click;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = $"insert into list values('{guna2TextBox1.Text}', '{guna2TextBox2.Text}')";
            db.InsertRow(query);
            MessageBox.Show("To do list task added successfully");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_list_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);
        }
    }
}

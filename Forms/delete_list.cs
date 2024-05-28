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
    public partial class delete_list : UserControl
    {
        DbHelper db;
        public event EventHandler RequestPanelBack;  // Define an event
        public delete_list()
        {
            InitializeComponent();
            db = new DbHelper();
            this.guna2ImageButton4.Click += guna2ImageButton4_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            // This will close the UserControl when the button is clicked
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM list WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query);
            MessageBox.Show("If the list item name exists in the databse it will be deleted successfully");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

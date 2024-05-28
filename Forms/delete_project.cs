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
    public partial class delete_project : UserControl
    {
        DbHelper db;
        public event EventHandler RequestPanelBack;  // Define an event
        public delete_project()
        {
            InitializeComponent();
            db = new DbHelper();
            this.guna2ImageButton4.Click += guna2ImageButton4_Click;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Button to add the project
            string tableName = guna2ComboBox1.Text.Replace(" ", "").ToLower();

            string query = $"DELETE FROM {tableName} WHERE name = '{guna2TextBox1.Text}'";
            db.DeleteRow(query);
            MessageBox.Show("If the Project name exists in the databse it will be deleted successfully");
        }

        private void delete_project_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            // This will close the UserControl when the button is clicked
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

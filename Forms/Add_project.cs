using Productivity_Nexus.Helpers;
using System;
using System.Windows.Forms;

namespace Productivity_Nexus.Forms
{
    public partial class Add_project : UserControl
    {
        DbHelper db;
        public event EventHandler RequestPanelBack;  // Define an event

        public Add_project()
        {
            InitializeComponent();
            db = new DbHelper();
            this.guna2ImageButton4.Click += guna2ImageButton4_Click;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Text box for the project name
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Text box for the project description
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combo box for the project status
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Button to add the project
            string tableName = guna2ComboBox1.Text.Replace(" ", "").ToLower();
            string query = $"insert into {tableName} values('{guna2TextBox1.Text}', '{guna2TextBox2.Text}', '{guna2ComboBox1.Text}')";
            db.InsertRow(query);
            MessageBox.Show("Project Added Successfully");
        }

        private void Add_project_Load(object sender, EventArgs e)
        {
            // Load event for UserControl
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            // This will close the UserControl when the button is clicked
            this.Dispose(); // Use Dispose if you want to completely remove the UserControl
            RequestPanelBack?.Invoke(this, EventArgs.Empty);
        }
    }
}

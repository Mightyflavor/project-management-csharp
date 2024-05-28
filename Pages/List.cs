using Productivity_Nexus.Forms;
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

namespace Productivity_Nexus.Pages
{
    public partial class List : UserControl
    {
        DbHelper db;
        add_list add_List;
        public List()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void list1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            db.get_list("select * from list", flowLayoutPanel1);

        }
        private void addUserControl2(UserControl userControl)
        {
            panel1.Controls.Clear(); // Clear existing controls
            panel1.Controls.Add(userControl); // Add the new user control
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront(); // Ensure the user control is at the front of panel2
            panel1.BringToFront();  // This will bring the panel2 to the front, ensuring visibility
        }

        private void Add_List_RequestPanelBack(object sender, EventArgs e)
        {
            // Logic to send panel2 to the back
            panel1.SendToBack();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add_list add_List = new add_list();
            addUserControl2(add_List);
            add_List.RequestPanelBack += Add_List_RequestPanelBack;
           
        }


       

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            delete_list delete_List = new delete_list();
            addUserControl2(delete_List);
            delete_List.RequestPanelBack += Add_List_RequestPanelBack;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

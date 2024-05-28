using Productivity_Nexus.Components;
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
using Productivity_Nexus.Forms;
using Guna.UI2.WinForms;

namespace Productivity_Nexus.Pages
{
    public partial class Projects : UserControl
    {
        Add_project add_Project;
        delete_project delete_Project;

        public Projects()
        {
            InitializeComponent();
            //InitializeAddProject();
        }

        private void InitializeAddProject()
        {
            add_Project = new Add_project();
            panel2.Controls.Add(add_Project); // Assuming you want to display it in panel2
            add_Project.Dock = DockStyle.Fill;

            // Subscribe to the event
            add_Project.RequestPanelBack += Add_Project_RequestPanelBack;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            

        }

       


        private void Projects_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //db.getButtons("select * from items", flowLayoutPanel1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Projects_in_progress_parent projects_In_Progress = new Projects_in_progress_parent();
            addUserControl(projects_In_Progress);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Projects_completed_parent projects_Completed = new Projects_completed_parent();
            addUserControl(projects_Completed);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Projects_all_parent projects_All = new Projects_all_parent();
            addUserControl(projects_All);

        }



        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void projects_in_progress1_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //db.getButtons("select * from items", flowLayoutPanel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Add_project add_project = new Add_project();
            addUserControl2(add_project);

            // Subscribe to the event when a new instance is created
            add_project.RequestPanelBack += Add_Project_RequestPanelBack;
        }

        private void Add_Project_RequestPanelBack(object sender, EventArgs e)
        {
            // Logic to send panel2 to the back
            panel2.SendToBack();
        }

        private void addUserControl2(UserControl userControl)
        {
            panel2.Controls.Clear(); // Clear existing controls
            panel2.Controls.Add(userControl); // Add the new user control
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront(); // Ensure the user control is at the front of panel2
            panel2.BringToFront();  // This will bring the panel2 to the front, ensuring visibility
        }




        private void Projects_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            delete_project delete_Project = new delete_project();
            addUserControl2(delete_Project);

            // Subscribe to the event when a new instance is created
            delete_Project.RequestPanelBack += Add_Project_RequestPanelBack;
            
        }
    }
}

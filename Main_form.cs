using Productivity_Nexus.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Productivity_Nexus
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            Projects projects = new Projects();
            Calender calender = new Calender();
            List list = new List();
        }

        //adding user controls
        private void addUserControl(UserControl userControl) { 
            userControl.Dock=DockStyle.Fill;
            userControl.BringToFront();
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);

        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            addUserControl(projects);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            List list = new List();
            addUserControl(list);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            addUserControl(calender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            addUserControl(calendar);
        }

        private void panelcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

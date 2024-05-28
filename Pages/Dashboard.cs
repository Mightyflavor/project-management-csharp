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
    public partial class Dashboard : UserControl
    {
        DbHelper db;
        public Dashboard()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            db.get_list("select * from list", flowLayoutPanel1);
            

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int count = db.GetTotalRowCount("cancelled")+ db.GetTotalRowCount("completed")+ db.GetTotalRowCount("inprogresss");
            this.label8.Text = $"{count}";
            this.label9.Text= $"{db.GetTotalRowCount("completed")}";
            this.label10.Text = $"{db.GetTotalRowCount("inprogresss")}";
            this.label11.Text = $"{db.GetTotalRowCount("cancelled")}";
        }
    }
}

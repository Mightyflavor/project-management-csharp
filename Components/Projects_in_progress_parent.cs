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

namespace Productivity_Nexus.Components
{
    public partial class Projects_in_progress_parent : UserControl
    {
        DbHelper db;
        public Projects_in_progress_parent()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void projects_in_progress1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            db.getButtons("select * from inprogresss", flowLayoutPanel1);
            //db.InsertRow("insert into items2 values('item10','description1')");
        }
    }
}

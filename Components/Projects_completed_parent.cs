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
    public partial class Projects_completed_parent : UserControl
    {
        DbHelper db;
        public Projects_completed_parent()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void Projects_completed_parent_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            db.getButtons_for_completed("select * from completed", flowLayoutPanel1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void projects_completed1_Load(object sender, EventArgs e)
        {

        }
    }
}

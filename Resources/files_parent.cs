using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productivity_Nexus.Helpers;

namespace Productivity_Nexus.Resources
{
    public partial class files_parent : UserControl
    {
        DbHelper db = new DbHelper();
        public files_parent()
        {
            InitializeComponent();
        }

        private void files1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            db.get_files("select * from files", flowLayoutPanel1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

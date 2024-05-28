using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Nexus.Resources
{
    public partial class files : UserControl
    {
        public files()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void files_Load(object sender, EventArgs e)
        {

        }
    }
}

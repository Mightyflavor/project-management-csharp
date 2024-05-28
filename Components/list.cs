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
    public partial class list : UserControl
    {
        public list()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Description
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

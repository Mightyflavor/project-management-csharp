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
    public partial class Projects_all : UserControl
    {
        public Projects_all()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }
        public string ItemDescription
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string ItemStatus
        {
            get { return status.Text; }
            set { status.Text = value; }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }
    }
}

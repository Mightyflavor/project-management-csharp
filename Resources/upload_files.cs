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
    public partial class upload_files : UserControl
    {
        DbHelper db = new DbHelper();
        public upload_files()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            //dlg.DefaultExt = "*";
            //dlg.Filter = "All files" + "";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = dlg.FileName;
                MessageBox.Show("The file was stored successfully");
                db.InsertRow($"insert into files values ('{filename}')");
            }

        }
    }
}

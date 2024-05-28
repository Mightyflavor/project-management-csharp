using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Productivity_Nexus.Resources;

namespace Productivity_Nexus.Pages
{
    public partial class Calender : UserControl
    {
        public Calender()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calender_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Use Windows Forms OpenFileDialog
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.DefaultExt = "*.*"; 
            dlg.Filter = "All files (*.*)|*.*"; 

            // Show open file dialog box
            DialogResult result = dlg.ShowDialog(); 

            // Process open file dialog box results
            if (result == DialogResult.OK) 
            {
                // Open document
                string filename = dlg.FileName;
                
                MessageBox.Show("The file you selected was: " + filename);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            upload_files upload_Files = new upload_files();
            addUserControl(upload_Files);
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            files_parent files_Parent = new files_parent();
            addUserControl(files_Parent);

        }
    }
}

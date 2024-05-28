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
    public partial class Calendarr : UserControl
    {
        string _day, _date, _weekdays;
        public Calendarr(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();

        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }
    }
}

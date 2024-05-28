using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productivity_Nexus.Components;

namespace Productivity_Nexus.Pages
{
    public partial class Calendar : UserControl
    {
        public static int _year, _month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);

        }
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthname = new DateTimeFormatInfo().GetMonthName(month);
            label10.Text = monthname + " " + year.ToString();
            DateTime firstDay = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(firstDay.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                Calendarr c = new Calendarr("");
                flowLayoutPanel1.Controls.Add(c);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendarr c = new Calendarr(i+" ");
                flowLayoutPanel1.Controls.Add(c);
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

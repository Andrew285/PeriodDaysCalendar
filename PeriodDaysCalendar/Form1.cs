using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodDaysCalendar
{
    public partial class Form1 : Form
    {
        private CustomCalendar calendar;
        private List<Day> days;
        public Form1()
        {
            InitializeComponent();
            days = new List<Day>()
            {
                new Day(panel2, label10), new Day(panel3, label11),
                new Day(panel4, label12), new Day(panel5, label13),
                new Day(panel6, label14), new Day(panel7, label15),
                new Day(panel8, label16), new Day(panel9, label17),
                new Day(panel10, label18), new Day(panel11, label19),
                new Day(panel12, label20), new Day(panel13, label21),
                new Day(panel14, label22), new Day(panel15, label23),
                new Day(panel16, label24), new Day(panel17, label25),
                new Day(panel18, label26), new Day(panel19, label27),
                new Day(panel20, label28), new Day(panel21, label29),
                new Day(panel22, label30), new Day(panel23, label31),
                new Day(panel24, label32), new Day(panel25, label33),
                new Day(panel26, label34), new Day(panel27, label35),
                new Day(panel28, label36), new Day(panel29, label37),
                new Day(panel30, label38), new Day(panel31, label39),
                new Day(panel32, label40), new Day(panel33, label41),
                new Day(panel34, label42), new Day(panel35, label43),
                new Day(panel36, label44), new Day(panel1, label45),
                new Day(panel37, label46)
            };

            calendar = new CustomCalendar(days, MonthLabel, YearLabel);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalendarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            calendar.addMonth(0);
            calendar.Display();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            calendar.addMonth(1);
            calendar.Display();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            calendar.addMonth(-1);
            calendar.Display();
        }
    }
}

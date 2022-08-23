using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodDaysCalendar
{
    class CustomCalendar
    {
        private List<Day> days;
        private Label monthLabel;
        private Label yearLabel;
        private int currentMonth = DateTime.Now.Month;
        private int currentYear = DateTime.Now.Year;

        public CustomCalendar(List<Day> days, Label month, Label yearLabel)
        {
            this.days = days;
            this.monthLabel = month;
            this.yearLabel = yearLabel;
            //this.monthLabel.Text = DateTime.Now.ToString("MMMM");
            //this.yearLabel.Text = DateTime.Now.Year.ToString();
        }

        public void Display()
        {
            this.monthLabel.Text = new DateTime(currentYear, currentMonth, 1).ToString("MMMM");
            this.yearLabel.Text = new DateTime(currentYear, currentMonth, 1).Year.ToString();

            int firstDayPosition = CheckFirstDay();
            if(firstDayPosition >= 0)
            {
                int daysCounter = 0;
                int i = 0;
                while (i < days.Count)
                {
                    if(i >= firstDayPosition && i < DateTime.DaysInMonth(currentYear, currentMonth) + firstDayPosition)
                    {
                        days[i].Display(++daysCounter);
                    }
                    else
                    {
                        days[i].Clear();
                    }

                    i++;
                }
            }
        }

        public int CheckFirstDay()
        {
            var firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);

            switch(firstDayOfMonth.DayOfWeek.ToString())
            {
                case "Monday": return 0;
                case "Tuesday": return 1;
                case "Wednesday": return 2;
                case "Thursday": return 3;
                case "Friday": return 4;
                case "Saturday": return 5;
                case "Sunday": return 6;
                default: return -1;
            }
        }

        public void addMonth(int amount)
        {
            int temp = currentMonth + amount;

            if(temp > 12)
            {
                currentMonth = 1;
                currentYear += 1;
            }
            else if(temp < 1)
            {
                currentMonth = 12;
                currentYear -= 1;
            }
            else
            {
                currentMonth += amount;
            }
        }
    }

    class Day
    {
        private Panel panel;
        private Label label;
        private bool isDayOfPeriod;

        public Day(Panel panel, Label label)
        {
            this.panel = panel;
            this.label = label;
        }

        public void Display(int date)
        {
            this.label.Text = date.ToString();
        }

        public void Clear()
        {
            this.label.Text = "";
        }
    }
}

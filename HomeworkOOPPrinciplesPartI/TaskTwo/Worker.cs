using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private const int WorkdaysInWeek = 5;

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public Worker(string firstName, string lastName, int workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;

        }

        public decimal MoneyPerHour()
        {
            return Math.Round(this.WeekSalary / WorkdaysInWeek / this.WorkHoursPerDay, 2);
        }
    }
}

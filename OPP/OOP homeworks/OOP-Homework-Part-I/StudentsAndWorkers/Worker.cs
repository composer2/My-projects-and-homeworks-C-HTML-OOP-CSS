using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public double WeekSalary { get; private set; }
        public int WorkHoursDaily { get; private set; }
        public Worker(string firstName, string lastName, double weekSalary, int workHoursDaily)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursDaily = workHoursDaily;
        }

        public double MoneyHourly()
        {
            return this.WeekSalary / (double)(5 * this.WorkHoursDaily);//mon to fri 5work days
        }

        public override string ToString()
        {
            var worker = new StringBuilder();

            worker.AppendFormat("Money per hour: {0:f2}", this.MoneyHourly());
            worker.AppendLine();

            return base.ToString()+worker;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class WorkerFixSalary : WorkerBasic
    {
        public WorkerFixSalary(string firstName, string surName, int age, string department, string position, int experience, decimal rate) : base(firstName, surName, age, department, position, experience, rate)
        {
        this.hourlyPay = false;
        }

        public override decimal AverageSalary()
        {
            return rate;
        }
    }
}

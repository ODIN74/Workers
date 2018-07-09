using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal abstract class WorkerBasic : IComparable
    {
        protected string firstName { get; }
        protected string surName { get; }
        protected int age { get; }
        protected string department { get; set; }
        protected string position { get; set; }
        protected int experience { get; set; }
        protected bool hourlyPay { get; set; }
        protected decimal rate { get; set; }
        protected const decimal averageNumbersOfDays = 20.8m;
        protected const short workHours = 8;

        public WorkerBasic(string firstName, string surName, int age, string department, string position, int experience, decimal rate)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.age = age;
            this.department = department;
            this.position = position;
            this.experience = experience;
            this.rate = rate;
        }

        public abstract decimal AverageSalary();

        public int CompareTo(object obj)
        {
            WorkerBasic worker = (WorkerBasic)obj; 
            return String.Compare(this.surName, worker.surName);
        }

    }
}

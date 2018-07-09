using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerBasic[] workersArray = new WorkerBasic[] { new WorkerFixSalary("Иван", "Иванов", 24, "Бухгалтерия", "Бухгалтер", 1, 25000m),
                                                             new WorkerHourlySalary("Петр", "Петров", 34, "Цех № 8", "Токарь", 10, 200m),
                                                             new WorkerHourlySalary("Петр", "Михайлов", 28, "Цех № 8", "Фрезеровщик", 8, 250m),
                                                             new WorkerFixSalary("Михаил", "Васильев", 44, "Администрация", "Директор", 15, 150000m)};
            Console.WriteLine(workersArray[0].ToString());
            Console.WriteLine(workersArray[1].ToString());
            Console.WriteLine(workersArray[2].ToString());
            Console.WriteLine(workersArray[3].ToString());
            Array.Sort(workersArray);
            Console.WriteLine(workersArray[0].ToString());
            Console.WriteLine(workersArray[1].ToString());
            Console.WriteLine(workersArray[2].ToString());
            Console.WriteLine(workersArray[3].ToString());
            Console.ReadLine();
        }
    }
}

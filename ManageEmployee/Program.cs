using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("asdf","qwert",23);
            manager1.GetHoursAndPay();
            manager1.GetSalary();
            Console.ReadKey();
            
        }
    }
}

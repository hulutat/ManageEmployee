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
            Employee E1 = new Employee("Jon", "Jonas", 33);
            E1.GetHoursAndPay();
            E1.GetSalary();
            Person P1 = new Person("Harry", "Potter", 25);
            P1.Status();
            Console.ReadKey();
            
        }
    }
}

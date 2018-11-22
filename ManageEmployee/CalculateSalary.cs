using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployee
{
    public abstract class CalculateSalary:BasePerson
    {
        public int Hours { get; set; }
        public decimal PayPerH { get; set; }

        public void GetHoursAndPay()
        {
            Console.WriteLine();
            Console.WriteLine($"Insert the hours worked for {Name} {Lastname} ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Insert pay per hour {Name} {Lastname} ");
            PayPerH = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSalary()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} {Lastname} total salary : {PayPerH*Hours}$");
        }

        
    }
}

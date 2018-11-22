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
            Console.WriteLine("Insert the hours worked ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert pay per hour ");
            PayPerH = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Name} {Lastname} total salary : {PayPerH*Hours}");
        }

        
    }
}

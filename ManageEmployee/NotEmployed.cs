using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployee
{
   public abstract class NotEmployed:BasePerson
    {
        public void Status()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} {Lastname} is not employed!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployee
{
    class Person:NotEmployed
    {
        public Person (string name, string lastname, int age)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
        }
    }
}

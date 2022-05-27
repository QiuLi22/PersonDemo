using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"{LastName}, {FirstName}");
        }

        public void DisplayEmail()
        {
            Console.WriteLine($"{Email}");
        }
    }
}

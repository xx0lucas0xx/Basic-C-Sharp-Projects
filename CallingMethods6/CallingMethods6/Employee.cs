using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} with Employee ID {ID} has quit the company.");

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine($"{FirstName} with Employee ID {ID} has quit the company.");

        }
        public static bool operator ==(Employee a, Employee b)
        {
            //checks if two objects are equal and not null
            return a?.ID == b?.ID;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            //checks if two objects aren't equal
            return !(a == b);
        }
    }
    
}

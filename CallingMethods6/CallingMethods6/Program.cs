using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6
{
    class Program
    {
        static void Main(string[] args)
        {
            //instansiates employee object
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //creating object from IQuittable and assigns it to the employee object
            IQuittable IQuit = employee;

            //calling the Quit() method
            IQuit.Quit();

            

            employee.SayName();

            Console.ReadLine();

            
        }
    }
}

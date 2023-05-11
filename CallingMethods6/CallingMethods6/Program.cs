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
            //instansiates an employee object
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 1;


            //instansites a new employee object
            Employee employee2 = new Employee();

            employee2.FirstName = "Other";
            employee2.LastName = "Student";
            employee2.ID = 2;

            //instansiates a third employee object
            Employee employee3 = new Employee();

            employee3.FirstName = "Other";
            employee3.LastName = "Student";
            employee3.ID = 3;

           



            //creating object from IQuittable and assigns it to the employee object
            IQuittable IQuit = employee;

            //calling the Quit() method
            IQuit.Quit();

            

            employee.SayName();

            //using the comparison operators in the employee class
            bool Equal = employee2 == employee3;
            bool NotEqual = employee2 != employee3;

            Console.WriteLine("Are these the same employees? " + Equal);
            Console.WriteLine("Are these different employees? " + NotEqual);

            Console.ReadLine();

            
        }
    }
}

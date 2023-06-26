using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints the current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentDateTime);

            //asks user for a number
            Console.WriteLine("Please enter a whole number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //adds the users number in hours to the current time
            DateTime futureDateTime = currentDateTime.AddHours(userInput);
            Console.WriteLine(futureDateTime);

            Console.ReadLine();
        }
    }
}

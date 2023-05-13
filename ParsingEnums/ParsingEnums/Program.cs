using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    //Defining enum for days of the week
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //asks user to input the current week day
                Console.WriteLine("What day of the week is it?");
                string UserDay = Console.ReadLine();

                //checks if user input matches item in enum Days regardless of case
                Days Current = (Days)Enum.Parse(typeof(Days), UserDay, true);
                Console.WriteLine("Today is " + Current);
            }
            catch
            {
                //prints if user input does not match an item from enum Days
                Console.WriteLine("That is not a valid day of the week.");
            }

            Console.ReadLine();

           
        }
    }
}

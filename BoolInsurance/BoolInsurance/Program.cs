using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for insurance?\nWell let's see!");
            Console.ReadLine();

            Console.WriteLine("\nWhat is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("\nHello there " + yourName);

            Console.WriteLine("\nHow old are you?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            

            Console.WriteLine("\nHave you ever had a DUI?\nanswer 'true' or 'false'.");
            string DUI = Console.ReadLine();
            bool DUItf = Convert.ToBoolean(DUI);

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string tick = Console.ReadLine();
            int tickInt = Convert.ToInt32(tick);

            Console.WriteLine("\nDo you qualify?");
           
            Console.WriteLine(ageInt > 15 && tickInt <= 3 && !DUItf );

            Console.ReadLine();

        }
    }
}

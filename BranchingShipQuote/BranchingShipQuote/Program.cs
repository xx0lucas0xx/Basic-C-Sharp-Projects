using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingShipQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning statment
            Console.WriteLine("Welcome to Package Express!\n\nPlease follow the instructions below.");
            Console.ReadLine();

            //Asks for package weight
            Console.WriteLine("\nWhat is the weight of your package?");
            string weight = Console.ReadLine();
            int weightInt = Convert.ToInt32(weight);

            //Checks if weight is over 50 if so exits program
            if (weightInt > 50)
            {

                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
            //asking for dimensions of package
            Console.WriteLine("What is the width of your package?");
            string width = Console.ReadLine();
            int widthInt = Convert.ToInt32(width);

            Console.WriteLine("What is the height of your package?");
            string height = Console.ReadLine();
            int heightInt = Convert.ToInt32(height);
            

            Console.WriteLine("What is the length of your package?");
            string length = Console.ReadLine();
            int lengthInt = Convert.ToInt32(length);

            int Total = (widthInt * heightInt * lengthInt);
            
            //Checks if package is avalible to ship or not
            if (Total > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express");
            }
            else
            {
                double grandTotal = (Total * weightInt / 100);
                Console.WriteLine("Your estimated total for shipping is: " + "$" + grandTotal);
                Console.ReadLine();
            
            }











            Console.ReadLine();
        }
    }
}

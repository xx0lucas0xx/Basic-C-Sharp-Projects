using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pick a number between 0-4!");
            string[] strArray = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };

            //asks user to pick an index
            int pick = Convert.ToInt32(Console.ReadLine());
            
            //if picked a viable number it displays the index slot that was picked
            if (pick >= 0 && pick < strArray.Length )
            {
                Console.WriteLine("You picked " + strArray[pick]);
            }
            else
            {
                Console.WriteLine("You picked a number that is not avalible");
            }

            //if picked a viable number it displays the index slot that was picked
            Console.WriteLine("pick a number between 0-3!");
            int[] intArray = new int[] { 1, 2, 3, 4 };

            pick = Convert.ToInt32(Console.ReadLine());

            if (pick >= 0 && pick < intArray.Length)
            {
                Console.WriteLine("You picked " + intArray[pick]);
            }
            else
            {
                Console.WriteLine("You picked a number that is not avalible");
            }

            //if picked a viable number it displays the index slot that was picked
            List<string> strList = new List<string>() {"Hey", "Hi", "Hello" };
            Console.WriteLine("pick a number between 0-2!");

            pick = Convert.ToInt32(Console.ReadLine());

            if (pick >= 0 && pick < strList.Count)
            {
                Console.WriteLine("You picked " + strList[pick]);
            }
            else
            {
                Console.WriteLine("You picked a number that is not avalible");
            }


            Console.ReadLine();
        }
    }
}

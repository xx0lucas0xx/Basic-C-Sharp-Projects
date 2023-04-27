using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user how many video games they want to buy
            Console.WriteLine("Lets see how much you'd pay per day with our video game financing options!");
            Console.ReadLine();

            Console.WriteLine("How many games would you like to buy? (They cost 60$ each) ");

            int IntHMGames = Convert.ToInt32(Console.ReadLine());

            //calls methods to use with user input
    
            Console.WriteLine(Game.weekly(IntHMGames * 60));

            Console.WriteLine(Game.mounthly(IntHMGames * 60));

            Console.WriteLine(Game.yearly(IntHMGames * 60));

            Console.ReadLine();
        }


    }
}

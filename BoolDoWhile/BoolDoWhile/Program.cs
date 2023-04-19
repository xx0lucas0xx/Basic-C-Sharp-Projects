using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //states that the number to be guessed is 4
            //asks 
            Console.WriteLine("Guess a number between 1 and 4?");
            int num = Convert.ToInt32(Console.ReadLine());
            bool numNum = num == 4;

            do
            {
                switch (num)
                {
                    //goes through list of numbers until 4 is chosen
                    case 3:
                        Console.WriteLine("3? ...Seriously? ...");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("3? ...Seriously? ...");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("3? ...Seriously? ...");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Ah yes you have taste.");
                        numNum = true;
                        break;
                    default:
                        Console.WriteLine("That's not even an option bro.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }
            while (!numNum);

            Console.Read();
        }
    }
}

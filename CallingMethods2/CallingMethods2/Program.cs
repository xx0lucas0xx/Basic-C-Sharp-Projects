using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods2
{
    class Program
    {
        static void Main(string[] args)
        {

            //asks user for a whole number
            Console.WriteLine("Write a whole number");
            int WNum = Convert.ToInt32(Console.ReadLine());

            //calls methods to use with user input

            Console.WriteLine(Numbers.maths(WNum));

            //asks user for a decimal
            Console.WriteLine("Write a decimal");
            decimal SFNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Numbers.maths(SFNum));


            //asks user for string number

            Console.WriteLine("Write a integer");
            string SNum = Console.ReadLine();
            int ISNum;

            //converts string into int
            if (int.TryParse(SNum, out ISNum))
            {
                Console.WriteLine(Numbers.maths(ISNum));
            }
            //throw error if incorrect input is put in
            else
            {
                Console.WriteLine("Invalid input, please input an integer");
            }


            

            Console.ReadLine();
        }
    }
}

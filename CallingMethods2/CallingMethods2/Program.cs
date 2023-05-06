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
            Numbers math = new Numbers();

            //asks user for a whole number
            Console.WriteLine("Write a whole number");
            int WNum = Convert.ToInt32(Console.ReadLine());

            //calls methods to use with user input

            Console.WriteLine(math.maths(WNum));

            //asks user for a decimal
            Console.WriteLine("Write a decimal");
            decimal SFNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(math.maths(SFNum));


            //asks user for string number
            Console.WriteLine("Write a integer");
            string SNum = Console.ReadLine();
         

            Console.WriteLine(math.maths(SNum));
            
            
       
            Console.ReadLine();
        }
    }
}

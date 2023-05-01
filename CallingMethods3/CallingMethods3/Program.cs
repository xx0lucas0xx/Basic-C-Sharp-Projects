using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for user to input a whole number
            Console.WriteLine("Enter a whole number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                //asks user for a second whole number
                Console.WriteLine("Enter a second whole number, or don't\nI don't really care.");
                int num2 = Convert.ToInt32(Console.ReadLine());




                Console.WriteLine(Numbers.maths(num1, num2));
            }
            
            //if the user inputs nothing it defaults num2 to 0
            catch
            {
                Console.WriteLine(Numbers.maths(num1));
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods5
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the class
            Numbers numbers = new Numbers();

            //asks user to input a whole number
            Console.WriteLine("Enter a whole number");
            int num = Convert.ToInt32(Console.ReadLine());

            numbers.maths(num);

            Console.ReadLine();
        }
    }
}

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
            //instantiates the Numbers class
            Numbers numbers = new Numbers();


            //asks user to input a whole number
            Console.WriteLine("Enter a whole number");
            int num = Convert.ToInt32(Console.ReadLine());

            numbers.maths(num);

            int input = 1;
            int output;

            numbers.PlusOne(input, out output);

            int x = 6;
            int y = 3;

            //using figures method with 2 paramaters
            int sum = Numbers2.figures(x, y);

            Console.WriteLine(sum);

            int z = 8;

            //using figures method with 1 paramater
            int sum2 = Numbers2.figures(z);

            Console.WriteLine(sum2);
            
        

            

            Console.ReadLine();

       
        }
    }
}

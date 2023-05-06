using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the class
            Numbers math = new Numbers();

            //passing in two numbers to the maths method
            math.maths(58, 23);

            Console.ReadLine();
        }
        
    }
}

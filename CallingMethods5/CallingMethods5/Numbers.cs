using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods5
{
    class Numbers
    {
        //overloaded method
        public void maths(int x)
        {
            // divides the user input by two and displays the equation
            int res = x / 2;
            Console.WriteLine(x + " / 2 = " + res);
        }

        public void PlusOne(int input, out int output)
        {
            //adds one to input
            output = input + 1;
            Console.WriteLine(input + " + 1 = " + output);
        }
    }
}

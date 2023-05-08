using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods4
{
    class Numbers
    {
        public void maths(int x, int y)
        {
            //solves first int operation and prints second one untouched
            int res = x * 12;
            Console.WriteLine(res + "\nThe second integer is: " + y);
        }
    }
}

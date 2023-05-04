using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods2
{
    public class Numbers
    {
        //first maths method
        //adds int
        public static int maths(int add)
        {
            return add + 2300;
        }

        //second maths method
        //converts float to int then subs
        public static decimal maths(decimal sub)
        {
            int Isub = Convert.ToInt32(sub);
            return Isub - 2300;
        }

        //third maths method
        //converts string into int then multis
        public static string maths(string multi)
        {
            string Smulti = Convert.ToInt32(multi);
            return multi * 2300;
        }


    }
}

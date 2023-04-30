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
        public static float maths(float sub)
        {
            int Isub = Convert.ToInt32(sub);
            return Isub - 2300;
        }

        //third maths method
        //converts string into int then multis
        public static int maths(string multi)
        {
            int Smulti = Convert.ToInt32(multi);
            return Smulti * 2300;
        }


    }
}

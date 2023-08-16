using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    //creating new class
    public class Game
    {
        //week pay method
        public static int weekly(int x)
        {
            return x * 7;
        }

        //mounth pay method
        public static int mounthly(int y)
        {
            return y * 30;
        }

        //year pay method
        public static int yearly(int z)
        {
            return z * 365;
        }

    }
}

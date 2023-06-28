using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiates new MeowMeow object
            MeowMeow Fluffy = new MeowMeow();

            //initiatews new MeowMeow object with default value of 0
            MeowMeow Mittens = new MeowMeow(0);

            Console.ReadLine();
        }
    }
}

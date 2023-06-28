using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatConstructors
{
    class MeowMeow
    {

        //adding const variable that can't be changed
        private const int Cats = 3;
        private int cats;

        //initilizes the cats variable
        public MeowMeow(int cats)
        {
            this.cats = cats;
            //if (cats > 0)
            //{
            //    Console.WriteLine("oh...okay that's a bit boring...you do you though...");
            //}
        }

        //Chaining two constructors together
        //displays error if user inputes a string
        public MeowMeow(string value)
        {
            Console.WriteLine("Use numbers silly!");
        }


        public MeowMeow() : this(Cats)
        {
            // asking how many cats the user has
            Console.WriteLine("How many cats do you have?");
            //converting user input to a string
            var HowManyStr = Console.ReadLine();
            int HowMany = int.Parse(HowManyStr);

            //stating if the user has too many cats or not
            if (HowMany > Cats)
            {
                Console.WriteLine("Huh...No Judgment but that might be a few to many...");
            }
            else if (cats == 0)
            {
                Console.WriteLine("oh...okay that's a bit boring...you do you though...");
            }

            else
            {
                Console.WriteLine("That's a good amount of cats mate!");
            }
        }
    }
}

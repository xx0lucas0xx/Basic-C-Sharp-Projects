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



        ////constructor setting up default properties to class Game
        //public Game()
        //{
        //    //price of game and lenght of game
        //    Price = 60;
        //    GameTime = 40;

        //}

        ////adding class property
        //public int Price { get; set; }
        //public int GameTime { get; set; }

    }
}

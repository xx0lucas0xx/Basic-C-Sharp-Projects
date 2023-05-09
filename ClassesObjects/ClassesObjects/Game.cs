using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    //Base class, cannot be seen unless inherented
    public abstract class Game
    {
        //prop tab tab making game properties
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //method must have override in inhereted methods, nessesary method
        public abstract void Play();


        //this virtual method gets inhereted but has ability to override it
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

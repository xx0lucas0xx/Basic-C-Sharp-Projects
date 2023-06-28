using System;
using System.IO;
using Casino;
using Casino.ClassesObjects;

//creating game twenty one
namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            //asking initaial questions
            Console.WriteLine("Welcome to the Grand Hotel and Casino.\nLet's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Helllo, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {  
                //adding new game and adding Guid identifier
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\spike\OneDrive\Documents\log\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }


                //starting a new game
                Game game = new TwentyOneGame();
                //adding player to the game
                game += player;
                player.isActivlyPlaying = true;
                while (player.isActivlyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //takes away player from game
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

    }
}

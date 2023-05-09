using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creating game twenty one
namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Lucas", "Amy", "John" };
            game.ListPlayers();
            Console.ReadLine();
        //    //initiates empty list
        //    Deck deck = new Deck();
        //    //instiates the shuffle method
        //    deck.Shuffle(3);


        //    //displays each card combo possible to display full deck amount of cards
        //    foreach (Card card in deck.Cards)
        //    {
        //        Console.WriteLine(card.Face + " of " + card.Suit);
        //    }
        //    //show deck constructor is creating a cards list and adding one card to it
        //    Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();
        //}






        //method to shuffle deck multiple times, calls prior method
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        }
    }
}

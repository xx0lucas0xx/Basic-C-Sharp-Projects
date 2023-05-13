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
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            ////initiates empty list
            //Deck deck = new Deck();
            ////instiates the shuffle method
            //deck.Shuffle(3);


            ////displays each card combo possible to display full deck amount of cards
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            ////show deck constructor is creating a cards list and adding one card to it
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

    }
}

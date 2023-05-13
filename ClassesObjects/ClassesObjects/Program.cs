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


            //initiates empty list
            Deck deck = new Deck();

            ////lambda function that counts the amount of aces in the deck
            ////x represents each element in the list
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 5, 8, 34, 23, 12, 9 };

            int sum = numberList.Sum();

            Console.WriteLine(sum);

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

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
            deck = Shuffle(deck);
            
            //displays each card combo possible to display full deck amount of cards
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //show deck constructor is creating a cards list and adding one card to it
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        
        //method to shuffle the deck
        public static Deck Shuffle(Deck deck)
        {
            //creates a temparary list of cards
            List<Card> TempList = new List<Card>();
            //randomizes the deck class
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                //grabs random card and puts it into a temparary deck until there are no more cards
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
            
        }
    }
}

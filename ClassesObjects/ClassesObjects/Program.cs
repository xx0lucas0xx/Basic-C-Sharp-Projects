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
            //initiates times shuffled
            int timesShuffled = 0;
            //shuffles deck 3 times and returns timesshuffled value
            deck = Shuffle(deck, out timesShuffled, 3);

            
            //displays each card combo possible to display full deck amount of cards
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //show deck constructor is creating a cards list and adding one card to it
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }
        



        //method to shuffle the deck
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            //adds an out
            timesShuffled = 0;
            for (int i = 0; i < times; i++) // i < times; allows deck to be shuffled multipule times
            {
                //adds one every time the deck is shuffled
                timesShuffled++;
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
            }
           
            return deck;
            
        }

        //method to shuffle deck multipul times, calls prior method
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}

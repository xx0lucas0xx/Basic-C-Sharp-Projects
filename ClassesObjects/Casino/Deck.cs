using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {       
        //Constructor for class Deck
        //Constructor is always name of the class
        public Deck()
        {
            //instantiates Cards as a empty list
            Cards = new List<Card>();

            //creates a new card 52 times
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        //method to shuffle the deck
        public void Shuffle(int times = 1)
        {
           
            for (int i = 0; i < times; i++) // i < times; allows deck to be shuffled multipule times
            {

                //creates a temparary list of cards
                List<Card> TempList = new List<Card>();
                //randomizes the deck class
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    //grabs random card and puts it into a temparary deck until there are no more cards
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }


        }
    }
}

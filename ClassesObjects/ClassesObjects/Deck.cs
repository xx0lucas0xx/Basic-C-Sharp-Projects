using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    public class Deck
    {       
        //Constructor for class Deck
        //Constructor is always name of the class
        public Deck()
        {
            //instantiates Cards as a empty list
            Cards = new List<Card>();

            //creates two more lists and instantiates values
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    //iterates 4 times to follow amount of values in Suits
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    //adds new card to card list
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
   
    //changed to struct (can't inharent)
    public struct Card
    {
        //adding class property
        //public makes accessable to whole program
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    
    //adding enums (like a limited list)
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

}

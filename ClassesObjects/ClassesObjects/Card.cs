using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    //creating new class (can reuse)
    //best to keep one class to one file
    public class Card
    {
        //constructor makes default properties to class Card
        public Card()
        {
            Suit = "Queen";
            Face = "Two";
        }   
        //adding class property
        //public makes accessable to whole program
        public string Suit { get; set; }
        public string Face { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Lucian";
            ////Shows escape charecter for adding "" inside a string
            //string quote = "The man said, \"Hello\", Lucien";
            ////shows how to tab
            //string dog = "\tDelilah";
            ////shows how to start new line
            //string tattoo = "I have a tattoo on my ankle and it says:\nBruh <3\nI am not joking in the slightest";
            ////shows how to add a backslash
            //string dude = "look\\one backslash!";

            ////basic bool contains and endswith
            //bool trueOrFalse = name.Contains("s");
            //bool falseOrTrue = name.EndsWith("n");

            ////counts amount of charecters in the name variable
            //int length = name.Length;

            ////changes name variable to uppercase
            //name = name.ToUpper();

            ////changes name variable to lowercase
            //name = name.ToLower();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Lucien");




            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}

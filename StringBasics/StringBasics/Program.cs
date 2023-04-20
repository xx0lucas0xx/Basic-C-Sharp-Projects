using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string guys = "Here with the guys\nWe got: ";
            string guy1 = "Lucien, ";
            string guy2 = "Keton, ";
            string guy3 = "and Delilah!";

            //Concatenates last 4 string var
            string dudes = guys + guy1 + guy2 + guy3;
            Console.WriteLine(dudes);

            //Changes string to uppercase
            string fella = "heyo";
            fella = fella.ToUpper();
            Console.WriteLine(fella);

            //Creates Stringbuilder that builds paragrapgh sentence at a time
            StringBuilder sb = new StringBuilder();

            sb.Append("It is such a beautiful day out! ");
            sb.Append("I can't wait to go for a walk with my friends later. ");
            sb.Append("It has been such crappy weather");
            sb.Append("\nit's nice to finally feel sun on my skin.");

            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}

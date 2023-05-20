using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputLog
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Log the number to a text file
            string filePath = "numbers.txt";
            File.WriteAllText(filePath, userInput);

            // Read the contents of the text file and print it back to the user
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("Contents of the text file:");
            Console.WriteLine(fileContents);
        }
    }
}

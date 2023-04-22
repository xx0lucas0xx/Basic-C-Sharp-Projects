using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //asks for user input on opinion on candy
        Console.WriteLine("name an animal");
        string[] strArray = new string[] { "Chocolate ", " Caramel ", " Gummies ", " Toffee ", " Gum " };

        string inputAnimal = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        //for loop iterates through array and adds text to end
        for (int i = 0; i < strArray.Length; i++)
        {
            sb.Append(strArray[i] + inputAnimal);
        }

        //writes out appeneded array
        Console.WriteLine(sb);

        //initiating intager
        int l = 0;

        //while l is greater than 6, print 'You're silly'
        while (l < 6)
        {
            Console.WriteLine("You're silly");

            //adds increment 
            l++;
        }

        //initiates hia as integer 3
        int hia = 4;

        //while hia is greater than or equal to 7, print 'It has been an amazing day!
        while (hia <= 7)
        {
            Console.WriteLine("It has been an amazing day!");

            //adds increment
            hia++;
        }


        //initiating meal list
        List<string> meals = new List<string>() { "breakfast", "lunch", "dinner" };

        //asks user to choose a meal
        Console.WriteLine("What's your favorite meal of the day?");
        string meal = Console.ReadLine();

        //itrates through meals to see if they match user input
        //displays input if matches an object on the list
        if (meal == "breakfast")
        {
            Console.WriteLine(meal + " is your favorite meal of the day!");
        }
        else if (meal == "lunch")
        {
            Console.WriteLine(meal + " is your favorite meal of the day!");
        }
        else if (meal == "dinner")
        {
            Console.WriteLine(meal + " is your favorite meal of the day!");
        }
        else
        {
            Console.WriteLine("You did not enter a valid meal");
        }

        Console.ReadLine();

        //initiating colours list
        List<string> colours = new List<string>() { "red", "orange", "yellow", "green", "red", "blue", "purple", "pink", "green" };

        //asks user to choose a color
        Console.WriteLine("what's your favorite colour?");
        string colour = Console.ReadLine();

        //finds index of user input
        int index = colours.FindIndex(a => a.Contains(colour));

        //displays applicable index
        Console.WriteLine(index);

        //initiates nums list
        List<string> nums = new List<string>() { "a", "b", "c", "d", "e", "c" };

        //checks if there are duplicate items in list nums
        foreach (string num in nums)
        {
            if (nums.Count() >= 2)
            {
                Console.WriteLine(num + " this item is a duplicate");

            }
            else
            {
                Console.WriteLine(num + " this item is unique");
            }
            {



                Console.ReadLine();




            }
        }
    }
}


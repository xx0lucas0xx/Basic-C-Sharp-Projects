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
        //asks for user to input an animal
        Console.WriteLine("name an animal");
        string[] strArray = new string[] { "Chocolate ", " Caramel ", " Gummies ", " Toffee ", " Gum " };

        string inputAnimal = Console.ReadLine();


        //for loop iterates through array and adds text to end
        for (int i = 0; i < strArray.Length; i++)
        {
            strArray[i] += inputAnimal;
        }

        foreach(string candy in strArray)
        {
            Console.WriteLine(candy);
        }



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
        if (meals.Contains(meal))
        {
            for (int i = 0; i < meals.Count; i++)
            {
                if (meals[i] == meal)
                {
                    Console.WriteLine(meal + " is at index " + i);
                }
            }
        }
        else
        {
            Console.WriteLine("You did not enter a valid meal");
        }
        

        Console.ReadLine();

        //initiating colours list
        List<string> colours = new List<string>() { "red", "orange", "yellow", "green", "red", "blue", "purple", "pink", "green" };
        Console.WriteLine("What is your favorite colour?");
        string colour = Console.ReadLine();

        //itrates through colours to see if they match user input
        //displays input if matches an object on the list
        if (colours.Contains(colour))
        {
            for (int i = 0; i < colours.Count; i++)
            {
                if (colours[i] == colour)
                {
                    Console.WriteLine(colour + " is at index " + i);
                }
            }
        }
        else
        {
            Console.WriteLine("You did not enter a valid colour");
        }

        //initiates nums list
        List<string> nums = new List<string>() { "a", "b", "c", "d", "e", "c" };

        //initiates empyty string
        List<string> nums2 = new List<string>() { };

        //checks if there are duplicate items in list nums
        foreach (string num in nums)
        {
            //if nums is a unique item it adds it to nums2 
            if (nums2.Contains(num))
            {
                Console.WriteLine(num + " this item is a duplicate");

            }
            else
            {
                Console.WriteLine(num + " this item is unique");
                nums2.Add(num);

            }

           
        }
         Console.ReadLine();
    }
}


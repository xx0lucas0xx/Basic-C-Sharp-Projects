using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //initiates a list and adds values
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);

        //removes value from list
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //initiates a list and adds values
        List<string> strList = new List<string>();
        strList.Add("Hello ");
        strList.Add("Bruh");

        //removes value from list
        strList.Remove("Bruh");

        Console.WriteLine(strList[0]);
        Console.ReadLine();



        //arrays are better for fixed amounts of data and large amounts of data


        //initiates array, declares what value and how many items will be in it
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        //initiates array, easier way to declare values
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //initiates array without having to declare it as new, it is assumed
        //easiest way to initalize array
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //changes the 6th number in the array
        numArray2[5] = 650;



        //reads the 4th number in your array
        Console.WriteLine(numArray2[5]);
        Console.ReadLine();

    }
}


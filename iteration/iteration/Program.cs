using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 35, 75, 86, 23 };

        ////for loop for as long as i is less than then number of items in the array
        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Lucien", "Lucas", "Luke", "Luci" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //        Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();


        ////initiating a list
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(100);
        //testScores.Add(97);
        //testScores.Add(86);
        //testScores.Add(78);
        //testScores.Add(70);

        ////for each loop
        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    { 
        //         Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();


        //List<string> names = new List<string>() { "Lucien", "Lucas", "Luke", "Luci" };

        ////Only displays name luke
        //foreach (string name in names)
        //{
        //    //remove if statement and leave console line to display all names in the list
        //    if (name == "Luke")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 99, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            //if it is a passing score it adds them from the testScores to the passingScores list
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
  

    }
}


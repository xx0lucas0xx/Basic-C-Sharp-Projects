using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      

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


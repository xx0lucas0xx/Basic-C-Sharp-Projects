using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays inital line
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Gets hourly rate for Person 1, converts string to float
            Console.WriteLine("\nPerson 1\nWhat is your hourly rate:");
            string hourlyRate1 = Console.ReadLine ();
            float hourly1 = float.Parse(hourlyRate1);

            //Gets hours worked weekly for Person 1, converts string to float
            Console.WriteLine("\nHow many hours do you work per week:");
            string hoursWorked1 = Console.ReadLine();
            float worked1 = float.Parse(hoursWorked1);

            //Gets hourly rate for Person 2, converts string to float
            Console.WriteLine("\nPerson 2\nWhat is your hourly rate:");
            string hourlyRate2 = Console.ReadLine();
            float hourly2 = float.Parse(hourlyRate2);

            //Gets hours worked weekly for Person 2, converts string to float
            Console.WriteLine("\nHow many hours do you work per week:");
            string hoursWorked2 = Console.ReadLine();
            float worked2 = float.Parse(hoursWorked2);

            //Finds out yearly salary for Person 1
            Console.WriteLine("\nAnnual salary of Person 1:");
            float total1 = hourly1 * worked1 * 52;
            Console.WriteLine(total1);

            //Finds out yearly salary for Person 2
            Console.WriteLine("\nAnnual salary of Person 1:");
            float total2 = hourly2 * worked2 * 52;
            Console.WriteLine(total2);

            //Checks who makes more money annualy
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool moreOr = total1 > total2;
            Console.WriteLine(moreOr);



            Console.ReadLine();





        }
    }
}

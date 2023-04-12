using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays inital line
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.ReadLine();

            //Questions and answers
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome back " + yourName + "!");

            Console.WriteLine("\nNow, Which course are you currently working on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine(currentCourse + "? Awesome!");
            

            Console.WriteLine("\nSo which page number are you on?");
            float pageNumber = Console.Read();
            Console.WriteLine("Page: " + pageNumber + " great work!");

            Console.WriteLine("\nDo you need help with anything?\nPlease answer 'true or 'false'.");
            string needHelp = Console.ReadLine();
            Console.WriteLine(needHelp + ", okay sounds good");

            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string userFeed = Console.ReadLine();
            Console.WriteLine(userFeed + "?" + " great!");

            Console.WriteLine("\nSo which page number are you on?");
            float studyHours = Console.Read();
            Console.WriteLine( studyHours + " that's awesome!");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}

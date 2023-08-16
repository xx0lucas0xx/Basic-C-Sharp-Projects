using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods7
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a list of 10 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { ID = 1, FirstName = "John", LastName = "Roberts" },
                new Employee { ID = 2, FirstName = "Adam", LastName = "Sandler" },
                new Employee { ID = 3, FirstName = "Joe", LastName = "Smith" },
                new Employee { ID = 4, FirstName = "Bob", LastName = "Johnson" },
                new Employee { ID = 5, FirstName = "Terry", LastName = "Jone" },
                new Employee { ID = 6, FirstName = "Joe", LastName = "Brown" },
                new Employee { ID = 7, FirstName = "Tom", LastName = "Davis" },
                new Employee { ID = 8, FirstName = "Beth", LastName = "Lee" },
                new Employee { ID = 9, FirstName = "Jack", LastName = "Gates" },
                new Employee { ID = 10, FirstName = "Karen", LastName = "Wilson" }
            };

            //creates a new list of employees with the first name joe in form of lambda expression
            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();

            //prints list of employees named Joe
            Console.WriteLine("Employees named 'Joe': ");
            foreach (Employee joe in joes)
            {
                Console.WriteLine($"ID: {joe.ID}, Name: {joe.FirstName} {joe.LastName}");
            }

            //creates a new list of employees with an ID greater than 5 in the form of a lambda expression
            List<Employee> fivePlus = employees.Where(x => x.ID > 5).ToList();

            //prints list of employees with an ID greater than 5
            Console.WriteLine("Employee ID > 5: ");
            foreach (Employee five in fivePlus)
            {
                Console.WriteLine($"ID: {five.ID}, Name: {five.FirstName} {five.LastName}");
            }

            Console.ReadLine();

        }
    }
}

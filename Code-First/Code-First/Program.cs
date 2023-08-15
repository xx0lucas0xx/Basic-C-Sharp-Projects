using System;

namespace Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                var newStudent = new Student
                {
                    //Creates a new student
                    FirstName = "Keaton",
                    LastName = "Dirks"
                };
                Console.WriteLine("Press enter to add a student to the database!");

                //Add the student to the context and save changes to the database
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("You have Succesfully added a student :)");
            }
        }
    }
}

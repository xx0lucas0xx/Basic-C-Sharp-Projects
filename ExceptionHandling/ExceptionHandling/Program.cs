using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)

        {
            //start of try and catch error block
            try
            {
                //asks user for two numbers to divide them
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }

            //Sends an error message if anything but int is submitted
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }

            //Sends an error message if user trys to divide by 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }

            //Sends an error for any error not perviously stated
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

            //Continues code even if
            finally
            {
                Console.ReadLine();
            }

        }
    }
}

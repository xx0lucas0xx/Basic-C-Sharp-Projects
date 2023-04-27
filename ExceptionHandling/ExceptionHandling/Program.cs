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

                //initiates number list
                List<int> MyNums = new List<int>() { 4, 7, 3, 7, 4, 9, 3, 5,};


                //asks user for a number to divide by list
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());



                for (int i = 0; i < MyNums.Count;)
                {
                    Console.WriteLine(MyNums[i] / numberOne);
                }
                Console.ReadLine();



                //foreach (int num in MyNums)
                //{
                //    while(MyNums.Count <)
                //}













                //Console.WriteLine("Pick a second number");
                //int numberTwo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Dividing the two...");
                //int numberThree = numberOne / numberTwo;
                //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Ask the user for his age.
            try
            {
                Console.WriteLine("Hello! Please enter your birthday in the format MM/DD:");
                string birthday = Console.ReadLine();
                Console.WriteLine("Please enter your age:");
                int age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    throw new AgeException();
                }



                DateTime birthdayCurr = DateTime.Parse(birthday + "/2018");

                bool isPassed = DateTime.Now > birthdayCurr;

                if (!isPassed)
                {
                    age = age + 1;
                }

                DateTime birthDate = DateTime.Parse(birthday + "/" + (2018 - age));

                //2.Display the year user born.

                Console.WriteLine("You were born in {0}!", birthDate.Year);


            }


            //3.Exceptions must be handled using "try .. catch".



            //4.Display appropriate error messages if user enters zero or negative numbers.



            //5.Display a general message if exception caused by anything else.



            catch (AgeException)
            {
                Console.WriteLine("Please enter a positive, non-zero integer only, no decimals or negative numbers please.");
                Console.ReadLine();
                return;
            }
            catch(FormatException)
            {
                Console.WriteLine("You have entered something incorrectly. Please try again.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }





            Console.ReadLine();


        }

        public class AgeException : Exception
        {
            public AgeException()
                : base() { }

            public AgeException(string message)
                : base(message) { }

        }



    }
}

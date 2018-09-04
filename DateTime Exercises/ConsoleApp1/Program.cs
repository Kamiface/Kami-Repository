using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    1. Prints the current date and time to the console.

            Console.WriteLine("Hello! The current date and time is {0}.", DateTime.Now);

            //    2. Asks the user for a number.

            Console.WriteLine("Please enter a number:");
            Time:
            try
            {

                float toHours = float.Parse(Console.ReadLine());
                TimeSpan hours = TimeSpan.FromHours(toHours);

                // This would also have worked  -->  TimeSpan hours = TimeSpan.FromHours(int.Parse(Console.ReadLine()));

                //    3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
                DateTime result = DateTime.Now + hours;

                Console.WriteLine("Okay! In {0} hours it will be {1}!", toHours, result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number!");
                goto Time;
            }



            Console.ReadLine();
        }
    }
}

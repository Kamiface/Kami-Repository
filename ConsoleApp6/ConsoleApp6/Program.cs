using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create an enum for the days of the week.

            //2. Prompt the user to enter the current day of the week.
            try
            {
                Console.WriteLine("Please enter the current day of the week:");
                string day = Console.ReadLine().ToLower();

                //3. Assign the value to a variable of that enum data type you just created.

                bool isEnum = DaysOfTheWeek.IsDefined(typeof(DaysOfTheWeek), day);
                
                if (isEnum == false)
                {
                    throw new FormatException ();
                }
                Console.WriteLine(isEnum);
            }
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        }


    public enum DaysOfTheWeek
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
           
}
    
}

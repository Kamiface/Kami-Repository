using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE: BOOLEAN LOGIC
            //Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and return a “true” or “false” at the end as to whether or not the applicant qualified for car insurance.

            //REQUIREMENTS
            //Ask the following questions:

            //What is your age ?

            Age:
            Console.WriteLine("What is your age?");

            int age;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter a number!");
                goto Age;
            }

        //Have you ever had a DUI ?

        Dui:
            Console.WriteLine("Have you ever had a DUI? Please enter \"True\" or \"False\"");

            bool DUI;
            try
            {
                DUI = bool.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter either \"True\" or \"False\"!");
                goto Dui;
            }

        //How many speeding tickets do you have?

        Tickets:
            Console.WriteLine("How many speeding tickets do you have?");

            int tickets;
            try
            {
                tickets = int.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter a number!");
                goto Tickets;
            }

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:

            //Applicants must be over 15 years old.

            //Applicants must not have any DUI’s.

            //Applicants must not have more than 3 speeding tickets.

            bool qualified = age > 15 & DUI == false & tickets <= 3;
            Console.WriteLine(qualified);

            //Print the result of the boolean expression created from the above business rules.

            if (qualified == true)
            {
                Console.WriteLine("Qualified:");
                Console.WriteLine(qualified);
                Console.WriteLine("Congratulations! You qualify!");
                Console.ReadLine();
                Environment.Exit(0);

            }

            Console.WriteLine("Qualified:");
            Console.WriteLine(qualified);
            Console.WriteLine("Sorry, you didn't qualify.");


            Console.ReadLine();

        }
    }
}

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
            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

    

            Age:
            Console.WriteLine("Please enter your age:");

            int age;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException Exception)
            {
                Console.WriteLine("Please enter a whole number!");
                goto Age;
            }


            Score:
            Console.WriteLine("Please enter your written test score (Number between 1-100)");
            int score;
            try
            {
                score = int.Parse(Console.ReadLine());
            }
            catch (FormatException Exception)
            {
                Console.WriteLine("Please enter a number!");
                goto Score;
            }


            Grade:
            Console.WriteLine("Please enter your flight test grade (A, B, C, D, or F");
            string grade = Console.ReadLine();




            while (age < 18)
            {

                if (score >= 80 && (grade == "A" || grade == "B" || grade == "C"))
                {
                    Console.WriteLine("You are too young. You must be over 18 to get a spaceship license.");
                    Console.WriteLine("Good job passing both tests at your age, you are certainly a prodigy. Come back when you are 18!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (score >= 80 && (grade == "D" || grade == "F"))
                {
                    Console.WriteLine("You are too young. You must be over 18 to get a spaceship license.");
                    Console.WriteLine("Good job passing the written test at your age, come back when you are 18!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (score < 80 && (grade == "A" || grade == "B" || grade == "C"))
                {
                    Console.WriteLine("You are too young. You must be over 18 to get a spaceship license.");
                    Console.WriteLine("Good job passing the flight test at your age, come back when you are 18!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                break;
            }

            //2. Do a boolean comparison using a do while statement.
            do
            {


                    if (score >= 80 && (grade == "A" || grade == "B" || grade == "C"))
                    {
                        Console.WriteLine("You qualify for your new Spaceship Pilot's License!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                if (score < 80 || (grade == "D" || grade == "F"))
                {
                    Console.WriteLine("Sorry! You do not qualify for a Spaceship Pilot's License.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            while (age > 18);




            //1. Do a boolean comparison using a do while statement.

            

            Console.ReadLine();


        }
    }
}

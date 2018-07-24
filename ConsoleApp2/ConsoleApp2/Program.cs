using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
          

            Console.WriteLine("What page number?");
            string pageNumString = Console.ReadLine();
            int pageNumInt = Convert.ToInt32(pageNumString);

            // I casted to int here, and parsed later, with the catch/goto, because I had an error when I casted to boolean on the section below (I input a non true/false in the console), 
            // so I wanted to see if I could fix that, and then decided to do it again with "Hours" for... reasons, I don't know. Because it was there :)


            Help:
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            try
            {
                bool helpBool;
                helpBool = bool.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please answer “true” or “false”");
                goto Help;
            }


            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positivesYay = Console.ReadLine();
          

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

        Hours:
            Console.WriteLine("How many hours did you study today?");
            try
            {
                int hours;
                hours = int.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please answer using a number!");
                goto Hours;
            }

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();


        }
    }
    }

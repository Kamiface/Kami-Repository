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

            //CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("1.) Please enter a number:");

            int numOne;
            numOne = int.Parse(Console.ReadLine());

            int resultOne = numOne * 50;

            Console.WriteLine("Thanks! " + numOne + " * 50 = " + resultOne);

            Task.Delay(750).Wait();

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("2.) Please enter another number:");

            int numTwo;
            numTwo = int.Parse(Console.ReadLine());

            int resultTwo = numTwo + 25;

            Console.WriteLine("Thanks! " + numTwo + " + 25 = " + resultTwo);

            Task.Delay(750).Wait();


            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("3.) Please enter a different number:");
            int numThree;
            numThree = int.Parse(Console.ReadLine());

            double resultThree = numThree / 12.5;

            Console.WriteLine("Thanks! " + numThree + " / 12.5 = " + resultThree);

            Task.Delay(750).Wait();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("4.) Please enter yet another number:");
            int numFour;
            numFour = int.Parse(Console.ReadLine());

            bool resultFour = numFour > 50;

            Console.WriteLine("Thanks! " + numFour + " > 50 = " + resultFour);

            Task.Delay(750).Wait();

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("5.) Please enter one more number:");
            int numFive;
            numFive = int.Parse(Console.ReadLine());

            int resultFive = numFive % 7;

            Console.WriteLine("Thanks! if you divide " + numFive + " by 7, the remainder is " + resultFive);

            Task.Delay(750).Wait();

            Console.WriteLine("Thank you! :D");

            Console.ReadLine();


        }
    }
}

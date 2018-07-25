using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonApp
{
    class Program
    {
        private static object Thanks;

        static void Main(string[] args)
        {

            //EXERCISE: MATH AND COMPARISON OPERATORS
            //Your job is to create an anonymous income comparison program.

            //REQUIREMENTS
            //The program must start by printing “Anonymous Income Comparison Program” to the screen.

            Console.WriteLine("Anonymous Income Comparison Program");

            //It must then print “Person 1” to the screen and get the following details:

            Console.WriteLine("Person 1");

            //Hourly Rate

            Console.WriteLine("Please input Person 1's hourly rate of pay:");
            decimal p1HourlyPay;
            p1HourlyPay = decimal.Parse(Console.ReadLine());

            Task.Delay(750).Wait();

            //Hours worked per week

            Console.WriteLine("Please input Person 1's hours worked per week:");
            int p1WeeklyHours;
            p1WeeklyHours = int.Parse(Console.ReadLine());

            Task.Delay(750).Wait();

            //It must then print “Person 2” to the screen and then get the following details:

            Console.WriteLine("Please input Person 2's hourly rate of pay:");
            decimal p2HourlyPay;
            p2HourlyPay = decimal.Parse(Console.ReadLine());

            Task.Delay(750).Wait();

            //Hourly rate

            Console.WriteLine("Please input Person 2's hours worked per week:");
            int p2WeeklyHours;
            p2WeeklyHours = int.Parse(Console.ReadLine());

            Task.Delay(750).Wait();

            //Hours worked per week

            //It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.

            Console.WriteLine("Annual salary of Person 1:");
            decimal p1AnnualSalary = (p1HourlyPay * p1WeeklyHours) * 52;
            Console.WriteLine(p1AnnualSalary);

            Task.Delay(750).Wait();

            //It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.

            Console.WriteLine("Annual salary of Person 2:");
            decimal p2AnnualSalary = (p2HourlyPay * p2WeeklyHours) * 52;
            Console.WriteLine(p2AnnualSalary);

            Task.Delay(750).Wait();

            //It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1larger = p1AnnualSalary > p2AnnualSalary;
            Console.WriteLine(p1larger);

            Task.Delay(750).Wait();

            Thanks! :)

            Console.ReadLine();
        }
    }
}

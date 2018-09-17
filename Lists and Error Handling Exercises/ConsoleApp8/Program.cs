using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            // IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            // 1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number 
            // the user entered, and displays the result to the screen.


            List<int> intList = new List<int>();
            intList.Add(5);
            intList.Add(24);
            intList.Add(82);
            intList.Add(37);
            intList.Add(61);
            intList.Add(4);
            intList.Add(96);
            intList.Add(15);
            intList.Add(48);
            intList.Add(52);

            Console.WriteLine("Please enter a number:");
            int divNum = int.Parse(Console.ReadLine());
            int result;

            foreach (int number in intList)
            {
                result = number / divNum;
                Console.WriteLine(result);
            }

            Console.ReadLine();

            // 2. Run that code, entering in non - zero numbers as the user. Look at the displayed results.

                        // Results are:
                        // Please enter a number:
                        // 3
                        // 1
                        // 8
                        // 27
                        // 12
                        // 20
                        // 1
                        // 32
                        // 5
                        // 16
                        // 17

            // 3. Run that code, entering in zero as the number to divide by. Note any error messages you get.

                        // Error Recieved:

                        // System.DivideByZeroException: 'Attempted to divide by zero.'

                        // An unhandled exception of type 'System.DivideByZeroException' occurred in ConsoleApp8.exe
                        // Attempted to divide by zero. occurred


            // 4. Run that code, entering in a string as the number to divide by. Note any error messages you get.

                        // Error Recieved:
                        // System.FormatException: 'Input string was not in a correct format.'

                        // An unhandled exception of type 'System.FormatException' occurred in mscorlib.dll
                        // Input string was not in a correct format.


            // 5. Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has 
            // emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations 
            // of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            List<int> intList2 = new List<int>();
            intList2.Add(5);
            intList2.Add(24);
            intList2.Add(82);
            intList2.Add(37);
            intList2.Add(61);
            intList2.Add(4);
            intList2.Add(96);
            intList2.Add(15);
            intList2.Add(48);
            intList2.Add(52);

            Console.WriteLine("Please enter a number:");

            try
                {
                int divNum2 = int.Parse(Console.ReadLine());
                int result2 = 0;
                foreach (int number2 in intList2)
                     {
                    result2 = number2 / divNum2;
                    Console.WriteLine(result2);
                     }
                }
            catch (Exception ex)
                {
                   
                    Console.WriteLine(ex.Message);
                }


            Console.WriteLine("Continuing with the program!");
            Console.ReadLine();


        }
    }
}

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

            //1.Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            Fruit:
            string[] stringArray = { "Apple", "Orange", "Banana", "Lime", "Lemon", "Watermelon", "Cherry" };

            Console.WriteLine("Input a number between 0 and 6 to select a fruit from the array:");
            int fruit;
            try
            {
               fruit = int.Parse(Console.ReadLine());
            }
            catch (FormatException Exception)
            {
                Console.WriteLine("Please input a number!");
                goto Fruit;
            }

            if (fruit > 6 || fruit < 0)
            {
                Console.WriteLine("Please enter a number between 0 and 6!");
                goto Fruit;
            }

            Console.WriteLine("You selected " + fruit + "! Your fruit selection is " + stringArray[fruit] + "!");


            //2.Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            //3.Add in a message that displays when the user selects an index that doesn’t exist.


            Integer:
            int[] intArray = { 6, 52, 9007, 152, 3, 98, 32, 7531, 8 };

            Console.WriteLine("Input a number between 0 and 8 to select a number from the array:");
            int arrNum;
            try
            {
                arrNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException Exception)
            {
                Console.WriteLine("Please input a number!");
                goto Integer;
            }

            if (arrNum > 8 || arrNum < 0)
            {
                Console.WriteLine("Please enter a number between 0 and 8!");
                goto Integer;
            }

            Console.WriteLine("You selected " + arrNum + "! You chose the number " + intArray[arrNum] + "!");





            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("Zero");
            stringList.Add("One");
            stringList.Add("Two");
            stringList.Add("Three");
            stringList.Add("Four");
            stringList.Add("Five");
            stringList.Add("Six");
            stringList.Add("Seven");
            stringList.Add("Eight");
            stringList.Add("Nine");
            stringList.Add("Ten");

            List:
            Console.WriteLine("Input an integer between 0 and 10 to select the equivalent string from the list:");
            int strList;
            try
            {
                strList = int.Parse(Console.ReadLine());
            }
            catch (FormatException Exception)
            {
                Console.WriteLine("Please input a number!");
                goto List;
            }

            if (strList > 8 || strList < 0)
            {
                Console.WriteLine("Please enter a number between 0 and 8!");
                goto List;
            }

            Console.WriteLine("You selected " + strList + "! You chose the number " + stringList[strList] + "!");
            Console.ReadLine();
        }
    }
}

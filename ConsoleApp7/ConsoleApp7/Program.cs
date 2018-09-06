using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create a one-dimensional array of strings. Ask the user to input some text. Create a loop that goes through each string in the array, 
            //adding the user’s text to the string. Then create a loop that prints off each string in the array on a separate line.

            //    string[] stringArray1 = { "I like ", "You like ", "We all like ", "Who doesn't like " };

            //    Console.WriteLine("Please enter an item or activity you like:");
            //    string favThing = Console.ReadLine();

            //    for (int i = 0; i < stringArray1.Length; i++)
            //    {
            //        stringArray1[i] = stringArray1[i] + favThing;

            //    }

            //    for(int i = 0; i < stringArray1.Length; i++)
            //    {
            //        Console.WriteLine(stringArray1[i]);
            //    }

            //    Console.ReadLine();

            //    //2.create an infinite loop.

            //    // Enjoy - Kami

            //    string[] lambChop = { "This is the song that never ends", "Yes, it goes on and on my friend", "Some people started singing it not knowing what it was", "And they'll never stop singing it forever just because" };



            //    for (int i = 0; i < lambChop.Length; i++)
            //    {
            //        Console.WriteLine(lambChop[i]);
            //        System.Threading.Thread.Sleep(1100);

            //        if (i == 3)
            //        {
            //            i = -1;
            //        }
            //    }


            ////    I also could have used:

            ////    for (; ; )
            ////    {
            ////        Console.WriteLine("This is the song that never ends");
            ////        Console.WriteLine("Yes, it goes on and on my friend");
            ////        Console.WriteLine("Some people started singing it not knowing what it was");
            ////        Console.WriteLine("And they'll never stop singing it forever just because"};
            ////}





            //    //3.fix the infinite loop so it will execute.

            //    //string[] lambChop2 = { "This is the song that never ends", "Yes, it goes on and on my friend", "Some people started singing it not knowing what it was", "And they'll never stop singing it forever just because" };



            //    //for (int i = 0; i < lambChop2.Length; i++)
            //    //{
            //    //    Console.WriteLine(lambChop2[i]);
            //    //    System.Threading.Thread.Sleep(1200);
            //    //}

            //    //Console.ReadLine();

            //    //4.create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Iteration " + i);
            //    }

            //    Console.ReadLine();


            //    //5.create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine("Iteration " + i);
            //    }

            //    Console.ReadLine();


            //    //6. Create a list of strings where each item in the list is unique. Ask the user to select text to search for in the list. Create a loop that 
            //    // iterates through the list, and then displays the index of the array that contains matching text on the screen.

            //    //7. Add code to the above loop that tells a user if they put in text that isn’t in the list.

            //    //8. Add code to that above loop that stops it from executing once a match has been found.


            //List<string> stuffThings = new List<string>();

            //stuffThings.Add("train");
            //stuffThings.Add("rabbit");
            //stuffThings.Add("wheel");
            //stuffThings.Add("memory");
            //stuffThings.Add("dinosaur");
            //stuffThings.Add("marble");
            //stuffThings.Add("goose");
            //stuffThings.Add("squirrel");
            //stuffThings.Add("apparatus");
            //stuffThings.Add("kettle");
            //stuffThings.Add("brass");
            //stuffThings.Add("ticket");
            //stuffThings.Add("jellyfish");
            //stuffThings.Add("parcel");
            //stuffThings.Add("cannon");
            //stuffThings.Add("stitch");

            //Console.WriteLine("Hello! Please name an item in the list to search for:");
            //string searchTerm = Console.ReadLine();
            //int found = 1;
            //int index;

            //foreach (string thing in stuffThings)
            //{
            //    if (string.Equals(thing, searchTerm, StringComparison.CurrentCultureIgnoreCase))
            //    {
            //        index = stuffThings.IndexOf(thing);
            //        Console.WriteLine("You searched for " + searchTerm + ", which is at the index " + index + " of this list!");
            //        found = 2;
            //        break;
            //    }
            //}

            //if (found == 1)
            //{
            //    Console.WriteLine("Sorry, not found!");
            //}

            //Console.ReadLine();



            //    //9.create a list of strings that has at least two identical strings in the list. ask the user to select text to search for in the list.
            //    //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.


            //    //10.add code to that above loop that tells a user if they put in text that isn’t in the list.


            List<string> moreThings = new List<string>();

            moreThings.Add("zephyr");
            moreThings.Add("stocking");
            moreThings.Add("mint");
            moreThings.Add("balloon");
            moreThings.Add("magic");
            moreThings.Add("company");
            moreThings.Add("holiday");
            moreThings.Add("grape");
            moreThings.Add("carriage");
            moreThings.Add("paper");
            moreThings.Add("earthquake");
            moreThings.Add("zephyr");
            moreThings.Add("zebra");
            moreThings.Add("balloon");
            moreThings.Add("birthday");
            moreThings.Add("paper");
           



            Console.WriteLine("Hello! Please name an item in the list to search for:");
            string searchTerm2 = Console.ReadLine();
            int found2 = 1;
            int index1 = 0;


            foreach (string stuff in moreThings)
            {
            

                if (string.Equals(stuff, searchTerm2, StringComparison.CurrentCultureIgnoreCase))
                {
                    
                    Console.WriteLine("You searched for " + searchTerm2 + ", which is at the index " + index1 + " of this list!");
                    found2 = 2;
                }

                index1 = index1 + 1;
            }

            if (found2 == 1)
            {
                Console.WriteLine("Sorry, not found!");
            }

            Console.ReadLine();

            //11.create a list of strings that has at least two identical strings in the list. create a foreach loop that evaluates each item in the list, 
            ////and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> AnotherList = new List<string>();

            AnotherList.Add("zephyr");
            AnotherList.Add("stocking");
            AnotherList.Add("mint");
            AnotherList.Add("balloon");
            AnotherList.Add("magic");
            AnotherList.Add("company");
            AnotherList.Add("holiday");
            AnotherList.Add("grape");
            AnotherList.Add("carriage");
            AnotherList.Add("magic");
            AnotherList.Add("holiday");
            AnotherList.Add("balloon");


            Console.WriteLine("Hello! Please name an item in the list to search for:");
            string search2 = Console.ReadLine();
            int found3 = 1;
            string searchdup = null;
            int index2 = 0;

            foreach (string list in AnotherList)
            {

                if (string.Equals(list, search2, StringComparison.CurrentCultureIgnoreCase))
                {

                    if (search2 == searchdup)
                    {
                        Console.WriteLine("Duplicate Entry! " + search2 + ", located at index " + index2 + ", has already appeared in the list at index " + index1 + "!");
                    }
                    else
                        Console.WriteLine("You searched for " + search2 + ", which is at the index " + index2 + " of this list!");
                    found3 = 2;
                    searchdup = search2;

                };
                index2 = index2 + 1;

            }

            if (found3 == 1)
            {
                Console.WriteLine("Sorry, not found!");
            }

            Console.ReadLine();

        }
    }
}

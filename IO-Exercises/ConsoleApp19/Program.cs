using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.Ask a user for a number.
            Console.WriteLine("Hello! Please input a number:");
            Input:
            try
            {
                int textFile = int.Parse(Console.ReadLine());

                //2.Log that number to a text file.

                File.WriteAllText(@"C:\Logs\Log.txt", Convert.ToString(textFile));

                //3.Print the text file back to the user.

                Console.WriteLine("Your number was {0}. You can find the logfile at C:\\Logs\\Log.txt", File.ReadAllText(@"C:\Logs\Log.txt"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a number!");
                goto Input;
            }
            Console.ReadLine();
        }
    }
}

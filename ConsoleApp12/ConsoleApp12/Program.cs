using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.

            //2. In the Main() method of the console app, instantiate the class.

            Class1 newInstance = new Class1();

            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

                Console.WriteLine("Please input a number:");
                int intOne = int.Parse(Console.ReadLine());



                Console.WriteLine("Please input another number (Optional - No Input = 1):");
                string input = Console.ReadLine();
                int intTwo = 1;
            try
            {
                intTwo = int.Parse(input);
            }
            catch (FormatException ex)
            {

            }


                newInstance.newMethod(intOne, intTwo);
                Console.WriteLine(newInstance.result1);
                Console.WriteLine("You entered {0} and {1}", intOne, intTwo);
                Console.WriteLine("({0} * {0}) / {1} = {2}!", intOne, intTwo, newInstance.result1);
            

 
        
            //5. Try various combinations of numbers on the code, including having no second number.

            Console.ReadLine();







        }
    }
}

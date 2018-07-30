using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            // The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.

            // 2. In the Main() program, ask the user what number they want to do the math operations on.

            // 3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.


         MathClass newMath = new MathClass();


        Math:
            try
            {
                Console.WriteLine("Please input a number to perform three math operations on:");
                int int1 = int.Parse(Console.ReadLine());

                newMath.math1(int1);
            
                Console.WriteLine("Thanks!");
                Console.WriteLine(int1 + " + " + int1 + " = " + newMath.returnInt1);

                newMath.math2(int1);

                Console.WriteLine("(" + int1 + " * " + int1 + ") + " + int1 + " = " + newMath.returnInt2);

                newMath.math3(int1);

                Console.WriteLine("(" + int1 + " + " + 4 + ") * " + int1 + " = " + newMath.returnInt3);

                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a number!");
                goto Math;
            }

        }
    }
}

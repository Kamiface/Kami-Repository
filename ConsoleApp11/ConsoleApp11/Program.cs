using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {



            //2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.


            Math newMath = new Math();


            One:
            try
            {
                Console.WriteLine("Please input a number to perform a math operation on:");
                int inputNum1 = int.Parse(Console.ReadLine());

                newMath.mathOp(inputNum1);

                Console.WriteLine("Thanks! {0} * {1} = {2}", inputNum1, inputNum1, newMath.returnNum1);

                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a number!");
                goto One;
            }

            // Did this try/catch here because the error message repeated infinitely when I tried it inside the method... need to look into that, not sure why that happens. 




            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.


            Math newMath2 = new Math();

            Two:
            try
            {

                Console.WriteLine("Please input another number to perform a math operation on:");

                decimal inputNum2 = decimal.Parse(Console.ReadLine());

                newMath2.mathOp(inputNum2);

                Console.WriteLine("Thanks! ({0} + {1}) * {2} = {3}", inputNum2, inputNum2, inputNum2, newMath2.returnNum2);

                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a number!");
                goto Two;
            }





            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.

            Math newMath3 = new Math();


            Three:
            try
            {
                Console.WriteLine("Please input a third number to perform a math operation on:");

                string inputNum3 = Console.ReadLine();

                int test = int.Parse(inputNum3);

                newMath3.mathOp(inputNum3);

                Console.WriteLine("Thanks! ({0} * {1}) - {2} = {3}", inputNum3, inputNum3, inputNum3, newMath3.returnNum3);

                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a number!");
                goto Three;
            }


            Console.ReadLine();

        


        }
    }
}

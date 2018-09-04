using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

            //2. In the Main() method, instantiate that class.

            Class1 newObj = new Class1();

            //3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Please input a number to divide it by 2:");
            int inputNum = int.Parse(Console.ReadLine());

            newObj.OutMethod(inputNum, out int outputNum);

            Console.WriteLine("Thanks! {0} / 2 = {1}!", inputNum, outputNum);

            Console.ReadLine();

            //4. Create a method with output parameters.
         

            newObj.output(72, 35, out int out1, out int out2);

            Console.WriteLine("The out parameters are {0} and {1}", out1, out2);

            Console.ReadLine();

            //5. Overload a method.

            newObj.Doppelganger(copy1: 37);
            newObj.Doppelganger(copy1: 37, copy2: 86);
            newObj.Doppelganger(copy2: 86, copy3: "Overloaded!");


            //6. Declare a class to be static. 

        }
    }
}

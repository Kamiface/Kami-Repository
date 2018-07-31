using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
   class Class1
    {

        //1.Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

        public void OutMethod(int inputNum, out int outputNum)
        {

            outputNum = inputNum / 2;


        }


        //4. Create a method with output parameters.

        public void output(int int1, int int2, out int out1, out int out2)
        {

            out1 = (int1 * 2) - int2;
            out2 = (int1 + int2) * 7;

        }
        

        //5. Overload a method.


        public void Doppelganger(int copy1)
        {
            Console.WriteLine(copy1);
            Console.ReadLine();
        }

        public void Doppelganger(int copy1, decimal copy2)
        {
            Console.WriteLine("{0}, {1}", copy1, copy2);
            Console.ReadLine();
        }

        public void Doppelganger(decimal copy2, string copy3)
        {
            Console.WriteLine("{0}, {1}", copy2, copy3);
            Console.ReadLine();
        }

        
    }

    //6. Declare a class to be static.

    public static class aClassApart
    {
        public static void ALonelyNote(string messageInABottle)
        { messageInABottle = "Hello from a static class, in a static void method. I'm stuck in here right now."; }


    }

            
        
    

        
    


}

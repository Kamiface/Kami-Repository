using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Class1
    {
        public int result1;
        public int intOne;
        public int intTwo;

        //1.Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.

        public int newMethod(int intOne, int intTwo = 1)
        {

            result1 = (intOne * intOne) / intTwo;
            return result1;

        }


    }
}

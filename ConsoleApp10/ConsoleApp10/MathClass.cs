using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
  
      class MathClass
    {




        // 1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
        // The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.
        public int returnInt1;
        public int returnInt2;
        public int returnInt3;

        public int math1(int int1)
        {

           returnInt1 = int1 + int1;
           return returnInt1;
            

        }


        public int math2(int int2)
        {

            returnInt2 = (int2 * int2) + int2;
            return returnInt2;

        }


        public int math3(int int3)
        {

            returnInt3 = (int3 + 4) * int3;
            return returnInt3;
        }




    }



}

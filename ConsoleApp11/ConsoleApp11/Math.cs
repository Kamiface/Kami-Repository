using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    class Math
    {




        //1.Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.

        public int returnNum1;
        public int returnNum2;
        public int returnNum3;


        public int mathOp(int inputNum1)
        {

            returnNum1 = inputNum1 * inputNum1;
            return returnNum1;


        }

        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.

        public int mathOp(decimal inputNum2)
        {

            decimal returnNumX = (inputNum2 + inputNum2) * inputNum2;
            returnNum2 = decimal.ToInt32(returnNumX);
            return returnNum2;

        }

        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

        public int mathOp(string inputNum3)
        {

            int inputNumX = int.Parse(inputNum3);
            returnNum3 = (inputNumX * inputNumX) - inputNumX;
            return returnNum3;
        }




    }



}

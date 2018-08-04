using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

            //2. In the Main() method, create an object of data type Number and assign an amount to it.

            Number number = new Number() { Amount = 52.3564m };

            //3. Print this amount to the console.

            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }
    }
    public struct Number
    {
        public decimal Amount { get; set; }
    }
}

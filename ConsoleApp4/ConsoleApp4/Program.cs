using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            //the first line of the program must be: “Welcome to package express. Please follow the instructions below.”

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //the user must then be prompted for the package weight.

            Weight:
            Console.WriteLine("Please enter the package weight:");

            float pkgWeight;
            try
            {
                pkgWeight = float.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter the package weight in numbers!");
                goto Weight;
            }


            //if the weight is greater than 50, display the error message, “package too heavy to be shipped via package express. have a good day.” at this point the program would end.


            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via package express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //the user must then be prompted for the package width.

            Width:
            Console.WriteLine("Please enter the package width:");

            float pkgWidth;

            try
            {
                pkgWidth = float.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter the package width in whole numbers!");
                goto Width;
            }

            //then the package height.

            Height:
            Console.WriteLine("Please enter the package height:");

            float pkgHeight;

            try
            {
                pkgHeight = float.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter the package height in whole numbers!");
                goto Height;
            }

            //then the package length.

            Length:
            Console.WriteLine("Please enter the package length:");

            float pkgLength;

            try
            {
                pkgLength = float.Parse(Console.ReadLine());
            }
            catch (FormatException helpException)
            {
                Console.WriteLine("Please enter the package width in whole numbers!");
                goto Length;
            }

            //if the dimensions total greater than 50, display the error message, “package too big to be shipped via package express.” at this point the program would end.

            float pkgVolume = (pkgLength * pkgWidth * pkgHeight);

            if (pkgVolume > 50)
            {
                Console.WriteLine("Package too big to be shipped via package express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //the total dimensions are then multiplied by the weight and then divided by 100.
            //the result of that calculation is the quote.

            float pkgQuote = (pkgVolume * pkgWeight) / 100;

            //display the quote to the user as a dollar amount.

            Console.WriteLine("Your quote for this package is $" + pkgQuote);

            Console.ReadLine();


        }
    }
}

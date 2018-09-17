using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Concatenate three strings.
            
            string string1 = "This is a string.";
            string string2 = "Strings are fun.";
            string string3 = "Let's all have fun with strings!";
            StringBuilder stringb = new StringBuilder();


            string bigstring1 = string1 + " " + string2 + " " + string3;
            string bigstring2 = $"{string1} {string2} {string3}";
            stringb.Append (string1 + " " + string2 + " " + string3);


            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(bigstring1);
            Console.WriteLine(bigstring2);
            Console.WriteLine(stringb);

            Task.Delay(1000);

            //Convert a string to uppercase.

            string notyell = "i am not yelling right now!";
            Console.WriteLine(notyell);
            String yell = notyell.ToUpper();
            Console.WriteLine(yell);

            Task.Delay(1000);


            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the opening sentence of my paragraph. ");
            
            sb.Append("This would be the second sentence of my paragraph. \n");
            
            sb.Append("That would mean this is the third sentence of my paragraph. ");
            
            sb.Append("This is such a cleverly written paragraph. ");
            
            sb.Append("The reader is definitely engaged and entertained.\n");
            
            sb.Append("Nowhere else will you find such an informative and intelligent paragraph. ");
            
            sb.Append("Final sentence in the paragraph (Say it ain't so!).");

            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}

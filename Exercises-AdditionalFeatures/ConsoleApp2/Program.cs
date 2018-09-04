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
            // 1. Create a const variable

            const string constant = "This string will never change once the program is compiled";

            // 2. Create a variable using the keyword "var".


            var itCouldBeAnything = "But VS has figured out that this is a string";

            

            // 3. Chain two constructors together.

            User user = new User();
            Console.WriteLine("Name: {0}, Promotional Balance: {1}, Ordered Previously? {2}.", user.userName, user.promoBalance, user.hasOrdered);

            Console.ReadLine();
        }





        public class User
        {
            public string userName;
            public int promoBalance;
            public bool hasOrdered;


            public User() : this("Kami", 100, true)
            {
            }

            public User(string userName, int promoBalance, bool hasOrdered)
            {
                this.userName = userName;
                this.promoBalance = promoBalance;
                this.hasOrdered = hasOrdered;
            }


        }
    }
    

        




    
}

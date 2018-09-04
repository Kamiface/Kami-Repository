using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [{0} {1}]", firstName, lastName);
        }

        // 2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

        public void Quit()
        {
            Console.WriteLine("The Employee Quits!");
        }

        // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
        // Hint: an object can be of an interface type if it implements that specific interface.
    }
}

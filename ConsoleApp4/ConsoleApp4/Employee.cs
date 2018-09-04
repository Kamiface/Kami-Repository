using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee : Person
    {
        //  3. Create another class called Employee and have it inherit from the Person class.

        //  4. Implement the SayName() method inside of the Employee class.

        public override void SayName()
        {
            Console.WriteLine("Name: [{0} {1}]", firstName, lastName);
        }
    }
}

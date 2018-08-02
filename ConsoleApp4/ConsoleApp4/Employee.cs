using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee : Person, IQuittable
    {

        // 1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.


        public int ID { get; set; }

        public static Employee operator== (Employee Id)
        {
            bool IdEqual = 
        }


        public override void SayName()
        {
            Console.WriteLine("Name: [{0} {1}]", firstName, lastName);
        }

       
        public void Quit()
        {
            Console.WriteLine("The Employee Quits!");
        }

       
    }
}

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


        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {

            // I also tried: return employee1.Id == employee2.Id

            bool IdCheck;
            if (employee1.Id == employee2.Id)
            {
                IdCheck = true;
            }
            else
            {
                IdCheck = false;
            }
            return IdCheck;
        }





        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // This is required

            bool IdCheckNeg;
            if (employee1.Id != employee2.Id)
            {
                IdCheckNeg = true;
            }
            else
            {
                IdCheckNeg = false;
            }
            return IdCheckNeg;

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

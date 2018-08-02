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
            // 1.Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            Employee employee1 = new Employee();

            employee1.firstName = "First";
            employee1.lastName = "Employee";
            employee1.Id = 123456;

            Employee employee2 = new Employee();

            employee2.firstName = "Second";
            employee2.lastName = "Employee";
            employee2.Id = 123456;

            bool check = employee1 == employee2;
            Console.WriteLine(check);

           

            //employee.SayName();

            //IQuittable newEmployee = new Employee();


            //newEmployee.Quit();

            Console.ReadLine();


        }
    }
}

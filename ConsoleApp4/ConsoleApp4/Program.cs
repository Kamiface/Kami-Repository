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

            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            //employee.SayName();

            //IQuittable newEmployee = new Employee();
            
            
            //newEmployee.Quit();

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main()
        {

            // 1.In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".

             Employee One = new Employee() { fName = "Sam", lName = "Jennings", id = 1 };
             Employee Two = new Employee() { fName = "Joe", lName = "Moore", id = 2 };
             Employee Three = new Employee() { fName = "Judith", lName = "French", id = 3 };
             Employee Four = new Employee() { fName = "Adrian", lName = "Kim", id = 4 };
             Employee Five = new Employee() { fName = "Christina", lName = "Sutton", id = 5 };
             Employee Six = new Employee() { fName = "Holly", lName = "Parker", id = 6 };
             Employee Seven = new Employee() { fName = "Stewart", lName = "Newman", id = 7 };
             Employee Eight = new Employee() { fName = "Joe", lName = "Connor", id = 8 };
             Employee Nine = new Employee() { fName = "Lillie", lName = "Strickland", id = 9 };
             Employee Ten = new Employee() { fName = "Gary", lName = "Myers", id = 10 };
             Employee Eleven = new Employee() { fName = "Molly", lName = "Briggs", id = 11 };
             Employee Twelve = new Employee() { fName = "Joe", lName = "Hunt", id = 12 };
             Employee Thirteen = new Employee() { fName = "Kristen", lName = "Knight", id = 13 };
             Employee Fourteen = new Employee() { fName = "Gordon", lName = "Hopkins", id = 14 };
             Employee Fifteen = new Employee() { fName = "Ramona", lName = "Smith", id = 15 };
             Employee Sixteen = new Employee() { fName = "Joe", lName = "Watson", id = 16 };


            List<Employee> employees = new List<Employee>();

            employees.Add(One);
            employees.Add(Two);
            employees.Add(Three);
            employees.Add(Four);
            employees.Add(Five);
            employees.Add(Six);
            employees.Add(Seven);
            employees.Add(Eight);
            employees.Add(Nine);
            employees.Add(Ten);
            employees.Add(Eleven);
            employees.Add(Twelve);
            employees.Add(Thirteen);
            employees.Add(Fourteen);
            employees.Add(Fifteen);
            employees.Add(Sixteen);

            Console.WriteLine("List of Everyone!");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + " " + employee.id);
            }

            Console.ReadLine();


            List<Employee> Joes = new List<Employee>();

            // 2.Using a foreach loop, create a new list of all employees with the first name "Joe".


            Console.WriteLine("List of Joes Separated From Everyone");
            foreach (Employee employee in employees)
            {
                if (employee.fName == "Joe")
                {
                    Console.WriteLine(employee.fName + " " + employee.lName + " " + employee.id);
                    Joes.Add(employee);
                }
            }
            Console.ReadLine();



            Console.WriteLine("List Of Just Joes");
            foreach (Employee employee in Joes)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + " " + employee.id);
            }


            Console.ReadLine();

            // 3.Do the same thing again, but this time with a lambda expression.

            List<Employee> lambdaJoes = employees.Where(x => x.fName == "Joe").ToList();

            Console.WriteLine("Lambda Joes");
            foreach (Employee x in lambdaJoes)
            {
                    Console.WriteLine(x.fName + " " + x.lName + " " + x.id);
            }
            Console.ReadLine();



            // 4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> lambdaIds = employees.Where(x => x.id > 5).ToList();

            Console.WriteLine("Lambda Ids");

            foreach (Employee x in lambdaJoes)
            {
                Console.WriteLine(x.fName + " " + x.lName + " " + x.id);
            }

            Console.ReadLine();

        }


    }

    public class Employee
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int id { get; set; }
    }
}

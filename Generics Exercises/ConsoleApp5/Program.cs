using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.

            Employee<string> employee1 = new Employee<string>();


            employee1.Things = new List<string>();



            employee1.Things.Add("One");
            employee1.Things.Add("Two");
            employee1.Things.Add("Three");
            employee1.Things.Add("Four");
            employee1.Things.Add("Five");
            employee1.Things.Add("Six");

            //4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.

            Employee<int> employee2 = new Employee<int>();

            employee2.Things = new List<int>();

            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);
            employee2.Things.Add(4);
            employee2.Things.Add(5);
            employee2.Things.Add(6);
            employee2.Things.Add(7);
            employee2.Things.Add(8);
            employee2.Things.Add(9);
            employee2.Things.Add(10);

            //5.Create a loop that prints all of the Things to the Console.
           
            for (int i = 0; i < employee1.Things.Count; i++)
            {

                Console.WriteLine(employee1.Things[i]);
                if (i == employee1.Things.Count - 1)
                {
                    for (int t = 0; t < employee2.Things.Count; t++)
                    {
                        Console.WriteLine(employee2.Things[t]);

                    }
                }
            }
            Console.ReadLine();
        }
    }
}

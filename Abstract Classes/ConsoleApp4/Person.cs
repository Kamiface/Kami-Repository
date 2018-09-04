using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Person
    {

        //  1. Create an abstract class called Person with two properties: string firstName and string lastName.


        public string firstName { get; set; }
        public string lastName { get; set; }


        //  2. Give it the method SayName().

        public virtual void SayName()
        {

        }


    }
}

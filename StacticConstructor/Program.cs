using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Person
    {
        public static string FirstName;             //static members
        public static string LastName;

        static Person()                                 //static constructor
        {
            FirstName = "Priya";                       //initalizing static members in static constructor
            LastName = "Survase";
            Console.WriteLine("Static Constructor {0} {1}", FirstName, LastName);
        }

        public Person()                                 //default constructor
        {
            Console.WriteLine("this is the default constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();               //creating object of class person (object of default constructor is created but the static constructor will be invoked first the the default is invoked)

            Console.ReadLine();
        }
    }
}

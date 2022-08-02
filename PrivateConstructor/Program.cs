using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priv_Constructor
{
    class Example
    {
        public static string name;                                //static members of class
        public static int age;


        private Example()                                         //private constructor
        {

        }
        public static void getInfo()                             //static method
        {
            Console.WriteLine("Info is: {0} {1}", name, age);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Example.name = "Priya";                                      //calling static members and methods of class       //cannot create obj of private constructor
            Example.age = 21;

            Example.getInfo();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int a, int b);              //creating delegate with same signature that of method to be pointed
    class Program
    {
        public static void addition(int a, int b)                  //methods
        {
            int result = a + b;
            Console.WriteLine("Addition is:{0}", result);
        }

        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is:{0}", result);
        }
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(addition);             //creating object of delegate and passing the refence of method to be called

            cal += subtraction;                                      //adding reference method of subtraction to the object of delegate

            cal(100, 20);



        }
    }
}

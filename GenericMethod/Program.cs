using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Example
    {
        public static void showArray<T>(T[] arr)              //creating a generic method with a placeholder T which can be used with any data type
        {
            for (int i = 0; i < arr.Length; i++)             //for display each elements present in array
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static bool Check<T>(T a, T b)
        {
            bool c = a.Equals(b);
            return c;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30 };                          //making integer type of an array

            string[] Names = { "Priya", "Pooja", "Shweta" };       //making string type of array

            Example.showArray(array);

            Example.showArray(Names);

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine(Example.Check(10, 10));
            Console.WriteLine(Example.Check(10.1, 10.11));
            Console.WriteLine(Example.Check("Priya", "Shweta"));
        }
    }
}

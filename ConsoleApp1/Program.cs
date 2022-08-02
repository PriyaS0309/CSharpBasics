using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            myArray[0] = 20;
            myArray[1] = 40;
            myArray[2] = 60;
            myArray[3] = 80;
            myArray[4] = 100;


            Console.WriteLine(myArray[3]);           //to access single elements using index number

            foreach (int i in myArray)                // to access each element using foreach loop
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Console.WriteLine(myArray.Length);        // to get the lenght of array
        }
    }
}


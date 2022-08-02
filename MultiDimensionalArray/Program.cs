using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultiDimensional_array_rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myNumber = new int[3, 4] //myNumber array with 3 rows and 4 columns
            {
                {5,10,15,20},
                {10,20,30,40 },
                {100,200,300,400 }
            };



            //  Console.WriteLine(myNumber[1,2]);                      //to access single element eg:30


            /* foreach (int item in myNumber)                        //accessing all elements of an array using foreach loop
             {
                 Console.WriteLine(item);
             }*/

            for (int i = 0; i < myNumber.GetLength(0); i++)        //for loop to access each element of an array
            {
                for (int j = 0; j < myNumber.GetLength(1); j++)
                {
                    Console.Write(myNumber[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


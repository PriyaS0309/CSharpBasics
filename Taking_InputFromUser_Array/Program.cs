using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingInputFromUser_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of Array:");
            int num = int.Parse(Console.ReadLine());                     //taking array size from user
            int[] MyArray = new int[num];                                 // creating array of size specifed by user

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter the data for array:");
                int data = int.Parse(Console.ReadLine());                    //take elemts from user ad storing it in data
                MyArray[i] = data;                                           //elements present in data are stored in array
            }

            Console.WriteLine("-----Your data is------");

            foreach (int item in MyArray)                                    //to display elements present in array
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

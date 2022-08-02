using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();                //Creates a collections of types list with int data type
            MyList.Add(20);                                    //adds elements in MyList
            MyList.Add(100);
            MyList.Add(30);
            MyList.Add(80);

            MyList.Insert(3, 60);                               // used to insert element in List

            MyList.Remove(60);                                  //to remove the element


            Console.WriteLine(MyList.Contains(100));            // checks if 100 is present in the list or not

            //  Console.WriteLine(MyList.Count);                    // used to count total numbers of elements present in List
            Console.WriteLine("-------------");

            foreach (int i in MyList)
            {
                Console.WriteLine(i);
            }

            MyList.Sort();                            //sorts the elements present in list

            Console.WriteLine("---Sorted List is:---");

            foreach (int i in MyList)                 //to print sorted list
            {
                Console.WriteLine(i);
            }

            MyList.Reverse();                         //reverses elements present in the list
            Console.WriteLine("-------------");
            foreach (int i in MyList)                 //to print sorted list
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

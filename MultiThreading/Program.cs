using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;                               //System.Threading namespace need to be added to work with threads


namespace MultiThreadingDemo
{
    class Program
    {
        public static void demo()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void demo1()
        {
            int a = 2;
            for (int i = 0; i <= 20; i++)
            {
                int result = a * i;
                Console.WriteLine(result);
            }
        }
        public static void demo2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(demo);                           //creating objects of thread to assign each function to threads 
            Thread t2 = new Thread(demo1);
            Thread t3 = new Thread(demo2);

            t1.Start();                             //start is used to start the thread
            t2.Start();
            t3.Start();
        }
    }
}

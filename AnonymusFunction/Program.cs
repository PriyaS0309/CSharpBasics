using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    public delegate void MyDelegate(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate md = delegate (int a, int b)
            {
                int result = a + b;
                Console.WriteLine("Result is:{0}", result);
            };
            md(20, 30);
            Console.ReadLine();
        }
    }
}

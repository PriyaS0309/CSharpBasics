using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStatement
{
    public delegate void LambdaStat(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            LambdaStat ls = (a, b) =>
            {
                int division = a / b;
                Console.WriteLine("Division is:{0}", division);
            };
            ls(20, 10);
            Console.ReadLine();
        }
    }
}

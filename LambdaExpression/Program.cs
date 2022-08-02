using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate void LambdaExp(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            LambdaExp le = (n1, n2) => Console.WriteLine("Result is:{0}", n1 * n2);
            le(10, 3);
        }

    }
}

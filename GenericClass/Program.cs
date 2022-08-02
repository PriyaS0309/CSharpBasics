using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Employee<T>
    {
        public void sum(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 + num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> e = new Employee<int>();
            Employee<string> e1 = new Employee<string>();
            e.sum(10, 20);
            e1.sum("Priya", "Survase");



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            int b = int.Parse(Console.ReadLine());

            try
            {
                int result = a / b;
                Console.WriteLine("Division is:" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero is not correct");
                Console.WriteLine(ex.Message);

                Console.WriteLine("Task Completed!!!!!!!!");
            }
        }
    }
}


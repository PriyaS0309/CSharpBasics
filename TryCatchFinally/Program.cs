using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for a:");
            int b = int.Parse(Console.ReadLine());

            try
            {
                int c = a / b;
                Console.WriteLine(c);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally                  //this block needs to executed in any condition i.e either the exection is handled or not or either execption has occured or not
            {
                Console.WriteLine("This block should be executed in any condition!!!!!");
            }

        }
    }
}

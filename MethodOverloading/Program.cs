using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Program1
    {
        public void add()
        {
            int a, b;
            Console.WriteLine("Enter the value for a & b:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Sum is:{0}", c);

        }

        public void add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }


        static void Main(string[] args)
        {
            Program1 p = new Program1();
            //p.add();
            p.add("Priya", "Survase");

            Console.ReadLine();
        }
    }
}


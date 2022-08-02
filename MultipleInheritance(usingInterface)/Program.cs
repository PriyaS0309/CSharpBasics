using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilpleInheritence_usingInterface
{
    interface Addition
    {
        void add();
    }
    interface Subtraction
    {
        void sub();
    }
    interface Result : Addition, Subtraction
    {
        void result();
    }

    class Details : Result
    {
        public void add()
        {
            int a = 10, b = 20;
            int r = a + b;
            Console.WriteLine("This is Addition interface method:{0}", r);
        }

        public void sub()
        {
            int a = 100, b = 20;
            int r = a - b;
            Console.WriteLine("This is Subtraction interface method:{0}", r);
        }

        public void result()
        {
            Console.WriteLine("This is result interface method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.add();
            d.sub();
            d.result();


        }
    }
}


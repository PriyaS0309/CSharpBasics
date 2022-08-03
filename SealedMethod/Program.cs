using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethodDemo
{
    class Staff
    {
        public virtual void show()
        {
            Console.WriteLine("This is staff method");
        }
    }
    class Manager : Staff
    {
        public sealed override void show()
        {
            Console.WriteLine("This is Manager method");
        }
    }
    class Developers : Manager
    {
        public void show1()                                  //here error occurs as the sealed method cannot be overriden
        {
            Console.WriteLine("This is Developer method");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Developers d = new Developers();
            d.show();
            Console.ReadLine();
        }
    }
}

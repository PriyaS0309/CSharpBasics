using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{

    class Parent                                                //base class with virtual method (virtual keyword is used to give authority to child class to use this method in its way)
    {
        public virtual void show()
        {
            Console.WriteLine("This is base class");
        }
    }
    class child : Parent
    {
        public override void show()                           // override keyword overrides the method of base class 
        {
            Console.WriteLine("This is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new child();                                 // when we create an object of child class with reference to parent class it will then also display the child method.
            p.show();

            child c = new child();
            c.show();

        }
    }
}

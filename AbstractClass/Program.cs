using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        public string name;
        public int age;
        public string address;
        public long phoneNo;

        public abstract void Details();
        public virtual void Detailss()
        {
            Console.WriteLine("Hello World");
        }


    }
    class Student : Person
    {
        public int RollNo;
        public int fees;

        public override void Details()
        {

            Console.WriteLine("Please enter name:{0}", name);
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age:", age);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter address:{0}", address);
            address = Console.ReadLine();
            Console.WriteLine("Please enter your Phone number:", phoneNo);
            phoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your RollNo:", RollNo);
            RollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Fees:", fees);
            fees = int.Parse(Console.ReadLine());
        }
    }
    class Teacher : Person
    {
        public int Salary;
        public string Qualification;

        public override void Details()
        {
            Console.WriteLine("Please enter name:{0}", name);
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age:", age);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter address:{0}", address);
            address = Console.ReadLine();
            Console.WriteLine("Please enter your Phone number:", phoneNo);
            phoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Salary:", Salary);
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Qualification:{0}", Qualification);
            Qualification = Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Student s = new Student();
             s.Details();*/

            Teacher t = new Teacher();
            t.Details();
        }
    }
}

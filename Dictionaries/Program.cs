using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictinoary_Generic_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees emp1 = new Employees()
            //{
            //    Id = 111,
            //    EmpName = "Priya",
            //    Salary=20000

            //};

            //Employees emp2 = new Employees()
            //{
            //    Id = 112,
            //    EmpName = "Shweta",
            //    Salary = 30000

            //};

            //Employees emp3 = new Employees()
            //{
            //    Id = 113,
            //    EmpName = "Pooja",
            //    Salary = 40000

            //};

            //Dictionary<int, Employees> myEmp = new Dictionary<int, Employees>();
            //myEmp.Add(emp1.Id, emp1);
            //myEmp.Add(emp2.Id, emp2);
            //myEmp.Add(emp3.Id, emp3);

            //Console.WriteLine(myEmp.Count(emp=>emp.Value.Salary > 20000 ));       //lambda expression counts the number of employees having salary greater then 20000



            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("Name", "Priya");
            myDict.Add("Last Name", "Survase");
            myDict.Add("Qualificaion", "BSc-IT");


            Console.WriteLine(myDict["Name"]);                        //to access single elements using there key name 

            Console.WriteLine("------------------------");

            Console.WriteLine(myDict.Count);

            Console.WriteLine(myDict.ContainsKey("Name"));


            Console.WriteLine("------------------------");

            foreach (var item in myDict)
            {
                Console.WriteLine("Key is:" + item.Key + "  " + "Value is:" + item.Value);
            }

            ////Console.WriteLine("-------------------------------------------------------------------------");

            ////Dictionary<int, string> MyD = new Dictionary<int, string>();
            ////MyD.Add(1, "MyName");
            ////MyD.Add(2, "Priya");
            ////MyD.Add(3, "Shweta");

            ////Console.WriteLine(MyD[3]);

            ////foreach (var item in MyD )
            ////{
            ////    Console.WriteLine(item.Value);
            ////}
        }
    }
}



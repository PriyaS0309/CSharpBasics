using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();
            MyList.Add(200);
            MyList.Add(60);
            MyList.Add(600);
            MyList.Add(40);
            MyList.Add(50);

            //var u = MyList.Where(x => x > 60).Take(2).ToList();      //it will print 200 and 600

            //var k = MyList.TakeWhile(x => x < 60).ToList();             //it will give 0 because before 60 there is no value which is less then 60

            var k = MyList.Skip(3).ToList();                    //it will skip start 3 numbers and print 40 and 50

            var q = MyList.SkipWhile(x => x > 40).ToList();     //it will skip all the elements that statisfies the condition  o/p is 40 and 50

            // var h = MyList.Distinct().ToList();                    //does not print the duplicate values

            //var isdata = MyList.Any();                           // to check whether the list contains data or not

            //var d = MyList.Contains(60);                         // to check whether the list contains some specified data

            //var methodSyntax = MyList.Where(num => num > 20).ToList();                     //where opertor for filtering data

            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //var data = MyList.OrderBy(num => num).ToList();                 //sorting data in ascending order

            //var myData = MyList.Where(num=>num>50).OrderByDescending(num => num).ToList();     //sorting data in descending order with where condition

            var data1 = MyList.AsEnumerable().Reverse();   //sorting data in reverse order
            foreach (var item in data1)
            {
                Console.WriteLine(item);
            }



            var query = MyList.All(x => x > 30);         //all operator that returns true or false if all elements of data source satisfies the condition



            //List<object> data = new List<object>();
            //data.Add("Priya");
            //data.Add(30);
            //data.Add("Shweta");
            //data.Add(40);
            //data.Add(50);

            //var methodsyn = data.OfType<int>().Where(x => x > 30).ToList();          //OfType 

            //foreach (var item in methodsyn)
            //{
            //    Console.WriteLine(item);
            //}





            Console.ReadLine();
        }

    }
}

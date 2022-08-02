using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello ");  // Creating StringBuilder
            sb.Append("Priya ");                              //appending stringBuilder
            sb.AppendLine("Survase");                         //appending strinbuilder and then going to next line
            sb.Append("Welcome");

            sb.Insert(12, " Pandharinath "); // inserting Pandharinath at index number 5

            sb.Remove(0, 5);                // removes string from 0th index till 5th position

            sb.Replace("Welcome", "Hello");   //replaces welcome string with hello

            Console.WriteLine(sb);

            string s1 = sb.ToString();
            Console.WriteLine(s1);


            StringBuilder sb1 = new StringBuilder();
            sb1.AppendFormat("{0:C}", 50);                   //appending string into specific format
            Console.WriteLine(sb1);
            Console.ReadLine();


        }
    }
}

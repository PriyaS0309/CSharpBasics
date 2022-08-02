using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentPartial sp = new StudentPartial();
            sp.First_Name = "Priya";
            sp.Last_Name = "Survase";
            sp.getInfo();
        }
    }
}

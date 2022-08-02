using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class StudentPartial
    {
        public void getInfo()
        {
            Console.WriteLine("Complete name is:" + FirstName + " " + LastName);
        }
    }
}

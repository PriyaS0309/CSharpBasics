using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class StudentPartial
    {
        private string FirstName;
        private string LastName;

        public string First_Name
        {
            set
            {
                FirstName = value;
            }
            get
            {
                return FirstName;
            }

        }

        public string Last_Name
        {
            set
            {
                LastName = value;
            }
            get
            {
                return LastName;
            }

        }

    }
}

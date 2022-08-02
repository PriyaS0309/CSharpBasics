using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_demo
{
    class employee
    {
        public int EmpId;
        public string EmpName;

        public double GrossSalary;
        public double deduction = 0.1;
        public double NetSalary;

        public employee(int EmpId, string EmployeeName, int EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmployeeName;
            this.GrossSalary = EmpSalary;
        }

        void CalculateSalary()
        {
            if (GrossSalary >= 20000)
            {
                NetSalary = GrossSalary - (GrossSalary * deduction);
                Console.WriteLine("Your Netsalary is:{0}", NetSalary);
            }
            else
            {
                Console.WriteLine("Your salary is:{0}", GrossSalary);
            }
        }

        public void ShowDetails()
        {
            this.CalculateSalary();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee(111, "Priya", 50000);
            e.ShowDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Employee Id is Mandatory")]                                       //required is given to EmployeeId but as EmployeeId is int it will acquire to EmployeeAge too because it has same datatype
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? EmployeeAge { get; set; }                    //? is used because it can accept null values too
        public string EmployeeGender { get; set; }
        public string EmployeeEmail { get; set; }
    }
}
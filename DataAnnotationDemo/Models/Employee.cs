using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Employee
    {
        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string OrganizationName { get; set; }

        [DisplayName("ID")]
        [Required(ErrorMessage ="Employee Id is Mandatory")]                                       //required is given to EmployeeId but as EmployeeId is int it will acquire to EmployeeAge too because it has same datatype
        public int EmployeeId { get; set; }

        [DisplayName("Full Name")]
        [Required(ErrorMessage ="Employee Name is Required")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name should have length between 5 and 20")]
        public string EmployeeName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage ="Employee age is required")]
        [Range(20,60,ErrorMessage ="Age should be between 20 and 60")]
        public int? EmployeeAge { get; set; }                    //? is used because it can accept null values too

        [DisplayName("Gender")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email Id")]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage ="Invalid Email ID")]
        public string EmployeeEmail { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password is required")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}",ErrorMessage ="Enter strong password")]
        public string  EmployeePassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage ="Confirm password is required")]
        [Compare("EmployeePassword",ErrorMessage ="Employee Password and Confirm Password does not match")]
        public string ConfirmEmpPassword { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterEmployee.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Enter Employee First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Employee Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter Employee's EmailID")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Enter Employee's Mobileno")]
        [MaxLength(10, ErrorMessage ="Invalid Mobile number!")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Select Question")]
        public string SecurityQuestion { get; set; }

        [Required(ErrorMessage = "Enter Answer")]
        public string Answer { get; set; }

        //[Required(ErrorMessage = "Enter Employee's Salary")]
        //[RegularExpression("([0-9]+)", ErrorMessage ="Enter numbers for salary!")]
        //public int Salary { get; set; }

        public List<Employee> AllEmployees { get; set; }
        

        public string ErrorMsg { get; set; }
    }
}

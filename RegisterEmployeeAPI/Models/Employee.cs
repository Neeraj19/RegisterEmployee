using System;
using System.Collections.Generic;

#nullable disable

namespace RegisterEmployeeAPI.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string SecurityQuestion { get; set; }
        public string Answer { get; set; }
    }
}

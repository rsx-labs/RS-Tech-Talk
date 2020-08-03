using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class Employee
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ConfirmEmail { get; set; }
        public string Country { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? DOB { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public bool IsPermanent { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public decimal Salary { get; set; }
        public string State { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class EmployeeSummary
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public Department Department { get; set; }
    }
}

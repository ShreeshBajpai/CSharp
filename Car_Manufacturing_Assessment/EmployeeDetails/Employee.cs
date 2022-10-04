using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int dept_id { get; set; }
        public int totalWorkingHrs { get; set; }

        public int totalSalary;
        public int minWorkingHrs;
    }
}


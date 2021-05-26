using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_PayRoll_Service_1
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public string Phone_Number { get; set; }
        public string Emp_Address { get; set; }
        public string Emp_DEPT { get; set; }
        public string Basic_Pay { get; set; }
        public string Deduction { get; set; }
        public float Taxable_Pay { get; set; }
        public float Income_Tax { get; set; }
        public float Net_Pay { get; set; }

    }
}

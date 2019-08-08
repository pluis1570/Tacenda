using ContractApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Models.People
{
    public class Employee : Person
    {
        public PayrollContract Payroll { get; set; }
        public EmployeeRole Role { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime dateTime { get; set; }
    }
}

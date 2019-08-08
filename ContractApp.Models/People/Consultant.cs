using ContractApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Models.People
{
    public class Consultant : Person
    {
        public PayrollContract Payroll { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
    }
}

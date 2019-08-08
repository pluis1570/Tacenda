using ContractApp.Models.Contracts;
using ContractApp.Models.Skills;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models.People
{
    public class Consultant : Person
    {
        public PayrollContract Payroll { get; set; }
        [Required]
        public List<Specialisation> Specialisation { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
    }
}

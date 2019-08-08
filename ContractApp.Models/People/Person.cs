using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models.People
{
    public class Person:BaseClass
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        public string Email { get; set; }
        public string TelNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models.People
{
    public class Account : BaseClass
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public ContactPerson Contact { get; set; }
    }
}

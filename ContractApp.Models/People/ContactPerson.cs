using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models.People
{
    public class ContactPerson : Person
    {
        [Required]
        public ContactPerson Contact { get; set; }
    }
}

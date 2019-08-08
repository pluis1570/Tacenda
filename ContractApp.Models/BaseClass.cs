using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models
{
    public class BaseClass
    {
        [Required]
        public Guid Id { get; set; }
    }
}

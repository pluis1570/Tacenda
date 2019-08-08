using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContractApp.Models.Contracts
{
    public class PayrollContract
    {
        public int PriceAHoure { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public string Details { get; set; }
        [Required]
        public ContractType Type { get; set; }
    }
}

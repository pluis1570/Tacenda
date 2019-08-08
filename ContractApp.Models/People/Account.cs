using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Models.People
{
    public class Account: BaseClass
    {
        public string CompanyName { get; set; }
        public ContactPerson Contact { get; set; }
    }
}

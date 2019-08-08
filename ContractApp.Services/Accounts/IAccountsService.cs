using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Services.Accounts
{
    public interface IAccountsService
    {
        List<Account> GetAllConsultants();
        Account GetConsultantById(int id);
        Account AddConsultant(Account a);
      
    }
}

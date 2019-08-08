using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Services.Consultants
{
    public interface IConsultantsService
    {
        List<Consultant> GetAllConsultants();
        Consultant GetConsultantById(Guid id);
        Consultant AddConsultant(Consultant a);
        void DeleteConsultant(Consultant a);
        void UpdateConsultant(Consultant a);

    }
}

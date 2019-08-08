using System;
using System.Collections.Generic;
using System.Text;
using ContractApp.Models.People;
using ContractApp.Repositories;

namespace ContractApp.Services.Consultants
{
    public class ConsultantsService : IConsultantsService
    {
        public readonly IRepository<Consultant> consultantRepo;
        public ConsultantsService(IRepository<Consultant> consultantRepo)
        {
            this.consultantRepo = consultantRepo;
        }


        public Consultant AddConsultant(Consultant a)
        {
            a.Id = Guid.NewGuid();
            return a;
        }

        public void DeleteConsultant(Consultant a)
        {
            throw new NotImplementedException();
        }

        public List<Consultant> GetAllConsultants()
        {
            List<Consultant> consultants = new List<Consultant>();
            consultants.Add(new Consultant()
            {
                Firstname = "Laurent",
                Lastname = "Luypaert",
                Birthday = DateTime.Now
            });

            consultants.Add(new Consultant()
            {
                Firstname = "Josh",
                Lastname = "Stone",
                Birthday = DateTime.Now
            });

            consultants.Add(new Consultant()
            {
                Firstname = "Betty",
                Lastname = "White",
                Birthday = DateTime.Now
            });
            return consultants;
        }

        public Consultant GetConsultantById(Guid id)
        {
            return this.consultantRepo.GetById(id);
        }

        public void UpdateConsultant(Consultant a)
        {
            throw new NotImplementedException();
        }
    }
}

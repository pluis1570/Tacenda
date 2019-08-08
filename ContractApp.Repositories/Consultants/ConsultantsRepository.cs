using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractApp.Repositories.Consultants
{
    public class ConsultantsRepository : IRepository<Consultant>
    {

        private List<Consultant> consultants;

        public ConsultantsRepository()
        {
            consultants = new List<Consultant>();
            consultants.Add(new Consultant()
            {
                Id = Guid.NewGuid(),
                Firstname = "Abraham",
                Lastname = "Linkon"
            });
        }
        public Consultant Create(Consultant entity)
        {
            this.consultants.Add(entity);
            return entity;
        }

        public void Delete(Consultant entity)
        {
            this.consultants.Remove(entity);
        }

        public IEnumerable<Consultant> GetAll()
        {
            return this.consultants;
        }

        public Consultant GetById(Guid id)
        {
            var Consultant = from c in this.consultants
                             where c.Id == id
                             select c;
            return consultants.SingleOrDefault();
        }

        public void Update(Consultant entity)
        {
            throw new NotImplementedException();
        }
    }
}

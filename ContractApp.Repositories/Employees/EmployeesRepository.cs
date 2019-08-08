using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractApp.Repositories.Employees
{
    public class EmployeesRepository : IRepository<Employee>
    {

        private List<Employee> employees;

        public EmployeesRepository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                Firstname = "Abraham",
                Lastname = "Linkon"
            });
        }
        public Employee Create(Employee entity)
        {
            this.employees.Add(entity);
            return entity;
        }

        public void Delete(Employee entity)
        {
            this.employees.Remove(entity);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employees;
        }

        public Employee GetById(Guid id)
        {
            var Consultant = from c in this.employees
                             where c.Id == id
                             select c;
            return employees.SingleOrDefault();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}

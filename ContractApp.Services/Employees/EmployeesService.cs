using System;
using System.Collections.Generic;
using System.Text;
using ContractApp.Models.People;
using ContractApp.Repositories;

namespace ContractApp.Services.Employees
{
    public class EmployeesService : IEmployeesService
    {
        public readonly IRepository<Employee> EmployeesRepo;
        public EmployeesService (IRepository<Employee> employeesRepo)
        {
            this.EmployeesRepo = employeesRepo;
        }


        public Employee AddConsultant(Employee a)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee a)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllConsultants()
        {
            throw new NotImplementedException();
        }

        public Employee GetConsultantById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee a)
        {
            throw new NotImplementedException();
        }
    }
}

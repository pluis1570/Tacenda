using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Services.Employees
{
    public interface IEmployeesService
    {
        List<Employee> GetAllConsultants();
        Employee GetConsultantById(int id);
        Employee AddConsultant(Employee a);
        void DeleteEmployee(Employee a);
        void UpdateEmployee(Employee a);
    }
}

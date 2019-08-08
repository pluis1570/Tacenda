using ContractApp.Models.People;
using ContractApp.Repositories;
using ContractApp.Repositories.Consultants;
using ContractApp.Repositories.Employees;
using ContractApp.Services.Consultants;
using ContractApp.Services.Employees;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApp.Api
{
    public static class StartUpHelpers
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Employee>, EmployeesRepository>();
            services.AddTransient<IEmployeesService, EmployeesService>();
            services.AddSingleton<IRepository<Consultant>, ConsultantsRepository>();
            services.AddTransient<IConsultantsService, ConsultantsService>();
        }

    }
}

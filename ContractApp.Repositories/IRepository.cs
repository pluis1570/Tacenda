﻿using ContractApp.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractApp.Repositories
{
    public interface IRepository<T> where T : Person
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Update(T entity);
        void Delete(T entity);
        T Create(T entity);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Repository.Infrastructure
{
  
    public interface IRepositoryBase<T> where T : class
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();


    }
}

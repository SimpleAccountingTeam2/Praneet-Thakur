﻿using SimpleAccounting.Model;
using SimpleAccounting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {

        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;
        private IUnitOfWork unitOfWork;
        private IAccountingCompanyDetailRepository countryRepository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public EntityService(IUnitOfWork unitOfWork, IAccountingCompanyDetailRepository countryRepository)
        {
            this.unitOfWork = unitOfWork;
            this.countryRepository = countryRepository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();

        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Edit(entity);
            _unitOfWork.Commit();

        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
              _unitOfWork.Commit();
       
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}

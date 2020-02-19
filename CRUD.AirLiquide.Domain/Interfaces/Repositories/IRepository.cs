using CRUD.AirLiquide.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CRUD.AirLiquide.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        TEntity GetById(Guid Id);

        IEnumerable<TEntity> GetAll();
        void Delete(Guid id);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}

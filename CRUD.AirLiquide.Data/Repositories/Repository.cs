using CRUD.AirLiquide.Data.Context;
using CRUD.AirLiquide.Domain.Core.Entities;
using CRUD.AirLiquide.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CRUD.AirLiquide.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected CRUDContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(CRUDContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(Guid Id)
        {
            return DbSet.Find(Id);
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
    }
}

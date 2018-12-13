using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CMS.ApplicationCore.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Remove(TEntity entity);
    }
}
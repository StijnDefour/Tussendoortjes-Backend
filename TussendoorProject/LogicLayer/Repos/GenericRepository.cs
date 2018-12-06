using LogicLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LogicLayer.Repos
{
    public abstract class GenericRepository<C, T> : IDisposable, IGenericRepository<T>
        where T : BaseEntity where C : DbContext, new()
    {
        private C _dataContext = new C();

        public C DataContext
        {
            get => _dataContext;
            set => _dataContext = value;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _dataContext.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dataContext.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}

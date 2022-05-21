using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryWebApplication.Data;
using LibraryWebApplication.Repository.Interfaces;
using System.Linq.Expressions;


namespace LibraryWebApplication.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected LibraryContext webDBContext { get; set; }
        public RepositoryBase(LibraryContext _webDBContext)
        {
            this.webDBContext = _webDBContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.webDBContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.webDBContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.webDBContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.webDBContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.webDBContext.Set<T>().Remove(entity);
        }
    }
}


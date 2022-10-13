using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly UniContext _dbContext;

        public GenericRepository(UniContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(T item)
        {
            _dbContext.Remove(item);
            _dbContext.SaveChanges();

        }

        public void Update(T item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public IEnumerable<T> GetByFilters(Expression<Func<T,bool>> whereExp)
        {
            IQueryable<T> myQuery = _dbContext.Set<T>();
            if (whereExp != null)
            {
                myQuery = myQuery.Where(whereExp);
            }
            return myQuery.ToList();
        }

        public IQueryable<T> GetByFiltersOrder(
           Expression<Func<T, bool>> whereExp,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderingExpression)
        {
            IQueryable<T> myQuery = _dbContext.Set<T>();
            if (whereExp != null)
            {
                myQuery = myQuery.Where(whereExp);
            }

            if (orderingExpression != null)
            {
                myQuery = orderingExpression(myQuery);
            }

            return myQuery;

        }
    }
}

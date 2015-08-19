using System;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Edit(T enntity);
        void Delete(T entity);
        void Save();
    }

}

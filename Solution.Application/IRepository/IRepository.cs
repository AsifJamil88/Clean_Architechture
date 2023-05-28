using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Application.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();

        void Delete(T entity);

        IEnumerable<T> Find(Expression<Func<T,bool>> exp);

        T FindById(int id);
    }
}

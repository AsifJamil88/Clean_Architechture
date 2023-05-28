using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Solution.Application.IRepository;
using Solution.Core.Models;

namespace Solution.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmployeeVacationManagementContext _db;
        public Repository(EmployeeVacationManagementContext db)
        {
            this._db = db;
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            
        }

        public void Delete(T entity)
        {
             _db.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }

        public T FindById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
    }
}

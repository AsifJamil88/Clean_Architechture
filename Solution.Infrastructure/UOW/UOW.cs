using Solution.Application.IRepository;
using Solution.Application.NewFolder;
using Solution.Core.Models;
using Solution.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Infrastructure.UOW
{
    public class UOW : IUOW
    {
        private readonly EmployeeVacationManagementContext _db;

        public UOW(EmployeeVacationManagementContext db)
        {
                this._db = db;
            EmployeeRepository = new EmployeeRepository(_db);
        }

        public IEmployeeRepository EmployeeRepository { get; private set; }

        public int Complete()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

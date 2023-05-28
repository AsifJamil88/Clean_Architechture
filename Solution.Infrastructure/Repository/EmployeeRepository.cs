using Solution.Application.IRepository;
using Solution.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Infrastructure.Repository
{
    public class EmployeeRepository : Repository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(EmployeeVacationManagementContext db) : base(db)
        {
        }

        public IEnumerable<Employee> GetAllManager()
        {
            return _db.Employees.Where(e => e.ManagerId != null).ToList();
        }
    }
}

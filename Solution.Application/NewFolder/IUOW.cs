using Solution.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Application.NewFolder
{
    public interface IUOW : IDisposable
    {
        public IEmployeeRepository EmployeeRepository { get; }
        int Complete();
    }
}

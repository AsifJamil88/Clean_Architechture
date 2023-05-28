using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.Application.NewFolder;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUOW _uow;

        public EmployeeController(IUOW uow)
        {
                this._uow = uow;
        }

        [HttpGet("GettAllEmployees")]
        public ActionResult GettAllEmployees()
        {
            var employeeList = _uow.EmployeeRepository.GetAll();
            return Ok(employeeList);
        }

    }
}

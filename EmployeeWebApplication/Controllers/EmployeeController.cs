using BusinessLogic.DTOS;
using BusinessLogic.SeviceLayer;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        [Route("PostEmployee")]
        public ActionResult<int> CreatingEmployee(EmployeeModelDTO employeeModel)
        {
            var postEmployee = _employeeService.PostEmployee(employeeModel);
            return Ok(postEmployee);
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public ActionResult<int> UpdateEmployee(EmployeeModelDTO employeeModel, int id)
        {
            var updateEmployee = _employeeService.UpdateEmployee(employeeModel, id);
            return Ok(updateEmployee);
        }
    }
}

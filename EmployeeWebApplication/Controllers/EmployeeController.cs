using DomainLogic.DomainLayer;
using DomainLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpPost]
        [Route("PostClient")]
        public ActionResult<int> CreatingClient(ClientModel clientModel)
        {
            var postClient = _employeeRepository.PostClient(clientModel);
            return Ok(postClient);
        }

        [HttpGet]
        public ActionResult<ClientModel> GetDetails()
        {
            var list=_employeeRepository.GetAll();
            return Ok(list);
        }
       
    }
}

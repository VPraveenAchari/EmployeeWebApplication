using DomainLogic.DomainLayer;
using DomainLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public ClientController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpPost]
        [Route("PostClient")]
        public ActionResult<ClientModel> CreatingClient(ClientModel clientModel)
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
        [HttpPut]
        [Route("UpdateClient")]
       public ActionResult<ClientModel> UpdateClients(ClientModel clientModel,int id)
        {
            var updateClient = _employeeRepository.UpdateClient(clientModel,id);
            return clientModel;
        }
        [HttpPost]
        [Route("PostEmployee")]
        public ActionResult<int> CreatingEmployee(EmployeeModel employeeModel)
        {
            var posteEmployee=_employeeRepository.PostEmployee(employeeModel);
            return Ok(posteEmployee);
        }
    }
}

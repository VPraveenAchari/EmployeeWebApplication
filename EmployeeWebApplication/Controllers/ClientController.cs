using BusinessLogic.DTOS;
using BusinessLogic.SeviceLayer;
using DomainLogic.DomainLayer;
using DomainLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public ClientController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        [Route("PostClient")]
        public ActionResult<ClientModelDTO> CreatingClient(ClientModelDTO clientModel)
        {
            var postClient = _employeeService.PostClient(clientModel);
            return Ok(postClient);
        }

        [HttpGet]
        public ActionResult<ClientModel> GetDetails()
        {
            var list = _employeeService.GetAll();
            return Ok(list);
        }
        [HttpPut]
        [Route("UpdateClient")]
       public ActionResult<ClientModelDTO> UpdateClients(ClientModelDTO clientModel,int id)
        {
            var updateClient = _employeeService.UpdateClientModel(clientModel,id);
            return clientModel;
        }
      /* 
        [HttpPost]
        [Route("PostEmployee")]
        public ActionResult<int> CreatingEmployee(EmployeeModelDTO employeeModel)
        {
            var postEmployee= _employeeService.PostEmployee(employeeModel);
            return Ok(postEmployee);
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public ActionResult<int> UpdateEmployee(EmployeeModelDTO employeeModel,int id)
        {
            var updateEmployee= _employeeService.UpdateEmployee(employeeModel,id);
            return Ok(updateEmployee);
        }
      */
    }
}

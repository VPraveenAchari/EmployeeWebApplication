using DomainLogic.DomainLayer;
using DomainLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public  ProjectController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpPost]
        public ActionResult<ProjectModel> CreatingProject(ProjectModel projectModel)
        {
            var postProject= _employeeRepository.PostProject(projectModel);
            return Ok(postProject);
        }

    }
}

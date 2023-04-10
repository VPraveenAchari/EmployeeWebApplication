using BusinessLogic.DTOS;
using BusinessLogic.SeviceLayer;
using DomainLogic.DomainLayer;
using DomainLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public  ProjectController(IEmployeeService employeeRepository)
        {
            _employeeService = employeeRepository;
        }
        [HttpPost]
        [Route("CreateProject")]
        public ActionResult<ProjectModelDTO> CreatingProject(ProjectModelDTO projectModel)
        {
            var postProject= _employeeService.PostProject(projectModel);
            return Ok(postProject);
        }
        [HttpPut]
        [Route("UpdateProject")]
        public ActionResult<ProjectModelDTO> UpdatingProject(ProjectModelDTO projectModel,int id) 
        {
            var updateProject=_employeeService.UpdateProject(projectModel,id);
            return Ok(updateProject);
        }
        [HttpPost]
        [Route("PostProjectMapping")]
        public ActionResult<ProjectResourceMappingModelDTO> CreateMapping(ProjectResourceMappingModelDTO projectResourceMappingModel) 
        { 
            var createMap=_employeeService.PostProjectMapping(projectResourceMappingModel);
            return Ok(createMap);
        }
    }
}

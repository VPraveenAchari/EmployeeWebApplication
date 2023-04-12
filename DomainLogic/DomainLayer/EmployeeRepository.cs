using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Data;
using DomainLogic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace DomainLogic.DomainLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _employeeRepository;
        public EmployeeRepository(EmployeeDbContext employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<ClientModel> GetAll()
        {
            var clientList = _employeeRepository.Clients.FromSqlRaw($"spGetClients").ToList();
            return clientList;
        }
        public ClientModel PostClient(ClientModel clientModel)
        {        
            var client = _employeeRepository.Database.ExecuteSqlRaw($"spPostClients {clientModel.ClientType},{clientModel.ClientName},{clientModel.ClientAddress}");
            return clientModel;
        }

       

        public EmployeeModel PostEmployee(EmployeeModel employeeModel)
        {
            
            var employee = _employeeRepository.Database.ExecuteSqlRaw($"spPostEmployee {employeeModel.FirstName},{employeeModel.LastName},{employeeModel.Phone},{employeeModel.Address},{employeeModel.City},{employeeModel.State},{employeeModel.Designation},{employeeModel.TechStack}");
            return employeeModel;
        }

        public ProjectModel PostProject(ProjectModel projectModel)
        {
            
            var project = new ProjectModel()
            {
                ProjectId = projectModel.ProjectId,
                ProjectName = projectModel.ProjectName,
                ProjectManager = projectModel.ProjectManager,
                ClientName= projectModel.ClientName,
            };
            var createProject = _employeeRepository.Database.ExecuteSqlRaw($"spPostProject {project.ClientName},{project.ProjectName},{project.ProjectManager}");
            return projectModel;
        }

        public ProjectResourceMappingModel PostProjectMapping(ProjectResourceMappingModel pp)
        {
            var createMapping = _employeeRepository.Database.ExecuteSqlRaw($"spPostProjectMapping {pp.ProjectName},{pp.EmployeeFirstName},{pp.EmployeeLastName},{pp.ManagerFirstName},{pp.ManagerLastName}");
            return pp;
        }

        public ClientModel UpdateClient(ClientModel clientModel,int id)
        {
           
            
            int client = _employeeRepository.Database.ExecuteSqlRaw($"spPutClient {id},{clientModel.ClientType},{clientModel.ClientName},{clientModel.ClientAddress}");
            return clientModel;
        }
        public EmployeeModel UpdateEmployee(EmployeeModel employeeModel,int id)
        {
           
            int employees = _employeeRepository.Database.ExecuteSqlRaw($"spPutEmployee {id},{employeeModel.FirstName},{employeeModel.LastName},{employeeModel.Phone},{employeeModel.Address},{employeeModel.City},{employeeModel.State},{employeeModel.Designation},{employeeModel.TechStack}");
            return employeeModel;
        }

        public ProjectModel UpdateProject(ProjectModel projectModel, int id)
        {
          
            int updateProject = _employeeRepository.Database.ExecuteSqlRaw($"spPutProject {id},{projectModel.ProjectName},{projectModel.ProjectManager},{projectModel.ClientName}");
            return projectModel;
        }
    }
}

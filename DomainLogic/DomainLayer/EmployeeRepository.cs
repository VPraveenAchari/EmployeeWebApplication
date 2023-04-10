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

        /*   public ClientModel PostClient(ClientModel clientModel)
           {
               _employeeRepository.Add(clientModel);
               _employeeRepository.SaveChanges();
               return clientModel;

               var client = _employeeRepository.Database.ExecuteSqlRaw($"spPostClients {clients.ClientType},{clients.ClientName},{clients.ClientAddress}");
                return clientModel;
           }*/

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

        public ProjectResourceMappingModel PostProjectMapping(ProjectResourceMappingModel projectResourceMappingModel)
        {
            var mapping = new ProjectResourceMappingModel()
            {
                ProjectResourceMappingId = projectResourceMappingModel.ProjectResourceMappingId,
                ProjectName = projectResourceMappingModel.ProjectName,
                EmployeeFirstName = projectResourceMappingModel.EmployeeFirstName,
                EmployeeLastName = projectResourceMappingModel.EmployeeLastName
            };
            var createMapping = _employeeRepository.Database.ExecuteSqlRaw($"spPostProjectMapping {mapping.ProjectName},{mapping.EmployeeFirstName},{mapping.EmployeeLastName}");
            return projectResourceMappingModel;
        }

        public ClientModel UpdateClient(ClientModel clientModel,int id)
        {
            //var clients1 = _employee.Clients.FirstOrDefault(x => x.ClientId == id);
            //var clients1 = _employee.Clients.Find(id);
            /*var clients = new ClientModel()
            {
                ClientId = id,
                    ClientName = clientModel.ClientName,
                    ClientAddress = clientModel.ClientAddress,
                    ClientType = clientModel.ClientType
                };*/
            
            
            int client = _employeeRepository.Database.ExecuteSqlRaw($"spPutClient {id},{clientModel.ClientType},{clientModel.ClientName},{clientModel.ClientAddress}");
            return clientModel;
        }
        public EmployeeModel UpdateEmployee(EmployeeModel employeeModel,int id)
        {
           /* var employee = new EmployeeModel()
            {
                EmployeeId = employeeModel.EmployeeId,
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                Phone= employeeModel.Phone,
                Address= employeeModel.Address,
                City= employeeModel.City,
                State= employeeModel.State,
                Designation= employeeModel.Designation,
                TechStack= employeeModel.TechStack
            };*/
            int employees = _employeeRepository.Database.ExecuteSqlRaw($"spPutEmployee {id},{employeeModel.FirstName},{employeeModel.LastName},{employeeModel.Phone},{employeeModel.Address},{employeeModel.City},{employeeModel.State},{employeeModel.Designation},{employeeModel.TechStack}");
            return employeeModel;
        }

        public ProjectModel UpdateProject(ProjectModel projectModel, int id)
        {
            var project = new ProjectModel()
            {
                ProjectId = projectModel.ProjectId,
                ProjectName = projectModel.ProjectName,
                ProjectManager = projectModel.ProjectManager,
                ClientName = projectModel.ClientName,
            };
            int updateProject = _employeeRepository.Database.ExecuteSqlRaw($"spPutProject {project.ProjectId},{project.ProjectName},{project.ProjectManager},{project.ClientName}");
            return projectModel;
        }
    }
}

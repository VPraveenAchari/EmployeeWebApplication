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
            var clients = new ClientModel()
            {
                ClientId = clientModel.ClientId,
                ClientName = clientModel.ClientName,
                ClientAddress = clientModel.ClientAddress,
                ClientType = clientModel.ClientType
            };
            var client = _employeeRepository.Database.ExecuteSqlRaw($"spPostClients {clients.ClientType},{clients.ClientName},{clients.ClientAddress}");
            return clientModel;
        }

        public int PostEmployee(EmployeeModel employeeModel)
        {
            var emp = new EmployeeModel()
            {
                EmployeeId= employeeModel.EmployeeId,
                FirstName= employeeModel.FirstName,
                LastName= employeeModel.LastName,   
                Phone= employeeModel.Phone,
                Address= employeeModel.Address,
                City= employeeModel.City,
                State= employeeModel.State,
                Designation=employeeModel.Designation,
                TechStack= employeeModel.TechStack,
            };
            var employee = _employeeRepository.Database.ExecuteSqlRaw($"spPostEmployee {emp.FirstName},{emp.LastName},{emp.Phone},{emp.Address},{emp.City},{emp.State},{emp.Designation},{emp.TechStack}");
            return employee;
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
            var projects = _employeeRepository.Database.ExecuteSqlRaw($"spPostProject {project.ClientName},{project.ProjectName},{project.ProjectManager}");
            return projectModel;
        }

        public ClientModel UpdateClient(ClientModel clientModel,int id)
        {
                //var clients1 = _employee.Clients.FirstOrDefault(x => x.ClientId == id);
                //var clients1 = _employee.Clients.Find(id);
                var clients = new ClientModel()
                {
                    ClientId = clientModel.ClientId,
                    ClientName = clientModel.ClientName,
                    ClientAddress = clientModel.ClientAddress,
                    ClientType = clientModel.ClientType
                };
            
            int client = _employeeRepository.Database.ExecuteSqlRaw($"spPutClient {clients.ClientId},{clients.ClientType},{clients.ClientName},{clients.ClientAddress}");
            return clientModel;
        }
    }
}

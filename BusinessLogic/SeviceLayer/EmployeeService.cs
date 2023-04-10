using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOS;
using DomainLogic.DomainLayer;
using DomainLogic.Models;

namespace BusinessLogic.SeviceLayer
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository,IMapper mapper) {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public List<ClientModelDTO> GetAll()
        {
            var clients=_employeeRepository.GetAll();
            return _mapper.Map<List<ClientModelDTO>>(clients);
        }

        public ClientModelDTO PostClient(ClientModelDTO clientModel)
        {
            var client = new ClientModelDTO()
            {
                ClientName = clientModel.ClientName,
                ClientAddress = clientModel.ClientAddress,
                ClientType = clientModel.ClientType
            };
            var clients=_mapper.Map<ClientModel>(client);
            var clients1 = _employeeRepository.PostClient(clients);
           return _mapper.Map<ClientModelDTO>(clients1);
        }
        public EmployeeModelDTO PostEmployee(EmployeeModelDTO employeeModel)
        {
            var emp = new EmployeeModelDTO()
            {
                EmployeeId = employeeModel.EmployeeId,
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                Phone = employeeModel.Phone,
                Address = employeeModel.Address,
                City = employeeModel.City,
                State = employeeModel.State,
                Designation = employeeModel.Designation,
                TechStack = employeeModel.TechStack,

            };
            //var employees=_mapper.Map<EmployeeModel>(employeeModel);
            var employees=_mapper.Map<EmployeeModel>(emp);
            var employee=_employeeRepository.PostEmployee(employees);
            return _mapper.Map<EmployeeModelDTO>(employee);
        }

        public ProjectModelDTO PostProject(ProjectModelDTO projectModel)
        {
            var project = _mapper.Map<ProjectModel>(projectModel);
            var projects=_employeeRepository.PostProject(project); 
            return _mapper.Map<ProjectModelDTO>(projects);
        }

        public ProjectResourceMappingModelDTO PostProjectMapping(ProjectResourceMappingModelDTO projectResourceMappingModel)
        {
            var projectMapping = _mapper.Map<ProjectResourceMappingModel>(projectResourceMappingModel);
            var projectMap = _employeeRepository.PostProjectMapping(projectMapping);
            return _mapper.Map<ProjectResourceMappingModelDTO>(projectMap);
        }

        public ClientModelDTO UpdateClientModel(ClientModelDTO clientModel, int id)
        {
            var clients = _mapper.Map<ClientModel>(clientModel);
            var client=_employeeRepository.UpdateClient(clients, id);
            return _mapper.Map<ClientModelDTO>(client);
        }

        public EmployeeModelDTO UpdateEmployee(EmployeeModelDTO employeeModel, int id)
        {
            var employees = _mapper.Map<EmployeeModel>(employeeModel);

            var employee =_employeeRepository.UpdateEmployee(employees, id);

            return _mapper.Map<EmployeeModelDTO>(employee);
        }

        public ProjectModelDTO UpdateProject(ProjectModelDTO projectModel, int id)
        {
            var projects = _mapper.Map<ProjectModel>(projectModel);
            var project=_employeeRepository.UpdateProject(projects,id);
            return _mapper.Map<ProjectModelDTO>(project);
        }


        /*public ClientModel PostClient(ClientModel clientModel)
       {
           var client = _employeeRepository.PostClient(clientModel);
           return client;
       }*/
    }
}

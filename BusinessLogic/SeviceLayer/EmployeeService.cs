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
        public ClientModel PostClient(ClientModel clientModel)
        {
            var client = _employeeRepository.PostClient(clientModel);
            return client;
        }

        public int PostEmployee(EmployeeModel employeeModel)
        {
            var employee=_employeeRepository.PostEmployee(employeeModel);
            return employee;
        }

        public ProjectModel PostProject(ProjectModel projectModel)
        {
            var projects=_employeeRepository.PostProject(projectModel); ;
            return projects;
        }

        public ClientModel UpdateClientModel(ClientModel clientModel, int id)
        {
            var client=_employeeRepository.UpdateClient(clientModel, id);
            return clientModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.DomainLayer;
using DomainLogic.Models;

namespace BusinessLogic.SeviceLayer
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public int PostClient(ClientModel clientModel)
        {
            var client = _employeeRepository.PostClient(clientModel);
            return client;
        }

        
    }
}

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
            var clients = new ClientModel()
            {
                ClientId = clientModel.ClientId,
                ClientName = clientModel.ClientName,
                ClientAddress = clientModel.ClientAddress,
                ClientType = clientModel.ClientType
            };
            var client = _employeeRepository.Database.ExecuteSqlRaw($"spPostClients {clients.ClientType},{clients.ClientName},{clients.ClientAddress}");
            // _employee.Add(client);
            //  _employee.SaveChanges();
            return client;
        }
    }
}

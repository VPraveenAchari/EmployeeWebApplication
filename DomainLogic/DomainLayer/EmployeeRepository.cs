using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Data;
using DomainLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace DomainLogic.DomainLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _employee;
        public EmployeeRepository(EmployeeDbContext employee)
        {
            _employee = employee;
        }

        public List<ClientModel> GetAll()
        {
            var clientList = _employee.Clients.FromSqlRaw($"spGetClients").ToList();
            return clientList;
        }

        //public List<ClientModel> PostClient(ClientModel clientModel)
        public int PostClient(ClientModel clientModel)
        {
            var clients = new ClientModel()
            {
                ClientId = clientModel.ClientId,
                ClientName = clientModel.ClientName,
                ClientAddress = clientModel.ClientAddress,
            };
            var client = _employee.Database.ExecuteSqlRaw($"spPostClients {clients.ClientType},{clients.ClientName},{clients.ClientAddress}");
            return client;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Models;

namespace DomainLogic.DomainLayer
{
    public interface IEmployeeRepository
    {
        int PostClient(ClientModel clientModel);
        List<ClientModel> GetAll();
    }
}

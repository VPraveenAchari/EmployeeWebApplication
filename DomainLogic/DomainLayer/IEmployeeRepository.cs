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
        ClientModel PostClient(ClientModel clientModel);
        List<ClientModel> GetAll();
        ClientModel UpdateClient(ClientModel client,int id);
        int PostEmployee(EmployeeModel employeeModel);
        ProjectModel PostProject(ProjectModel projectModel);

    }
}

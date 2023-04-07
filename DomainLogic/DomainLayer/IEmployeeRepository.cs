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
        EmployeeModel PostEmployee(EmployeeModel employeeModel);
        ProjectModel PostProject(ProjectModel projectModel);
        ProjectModel UpdateProject(ProjectModel projectModel, int id);
        EmployeeModel UpdateEmployee(EmployeeModel employeeModel, int id);
    }
}

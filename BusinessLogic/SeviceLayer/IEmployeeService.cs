using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOS;
using DomainLogic.Models;

namespace BusinessLogic.SeviceLayer
{
    public interface IEmployeeService
    {
        ClientModel PostClient(ClientModel clientModel);
        ClientModel UpdateClientModel(ClientModel clientModel,int id);
        int PostEmployee(EmployeeModel employeeModel);
        ProjectModel PostProject(ProjectModel projectModel);

    }
}

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
        ClientModelDTO PostClient(ClientModelDTO clientModel);
        List<ClientModelDTO> GetAll();
        ClientModelDTO UpdateClientModel(ClientModelDTO clientModel,int id);
        EmployeeModelDTO UpdateEmployee(EmployeeModelDTO employeeModel, int id);
        EmployeeModelDTO PostEmployee(EmployeeModelDTO employeeModel);
        ProjectModelDTO PostProject(ProjectModelDTO projectModel);
        ProjectModelDTO UpdateProject(ProjectModelDTO projectModel, int id);
    }
}

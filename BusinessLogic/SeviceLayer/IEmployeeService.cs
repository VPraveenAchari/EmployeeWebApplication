using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Models;

namespace BusinessLogic.SeviceLayer
{
    public interface IEmployeeService
    {
        int PostClient(ClientModel clientModel);
    }
}

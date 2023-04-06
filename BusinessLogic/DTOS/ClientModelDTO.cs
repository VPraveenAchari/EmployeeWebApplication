using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOS
{
    public class ClientModelDTO
    {
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientType { get; set; }
    }
}

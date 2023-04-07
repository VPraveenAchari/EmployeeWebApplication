using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BusinessLogic.DTOS
{
    public class ClientModelDTO
    {
        [JsonIgnore]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientType { get; set; }
    }
}

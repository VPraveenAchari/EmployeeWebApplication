using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogic.DTOS
{
    public class ProjectResourceMappingModelDTO
    {
        [JsonIgnore]
        public int ProjectResourceMappingId { get; set; }
        public string ProjectName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
    }
}

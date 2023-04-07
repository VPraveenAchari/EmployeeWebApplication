using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogic.DTOS
{
    public class ProjectModelDTO
    {
        [JsonIgnore]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ClientName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogic.DTOS
{
    public class EmployeeModelDTO
    {
        [JsonIgnore]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Designation { get; set; }
        public string TechStack { get; set; }
        public string ReportingManager { get; set; }
        public int CompanyId { get; set; }
    }
}

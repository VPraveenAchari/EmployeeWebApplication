using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace DomainLogic.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {

        }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<CompanyModel> Company { get; set; }
    }
}

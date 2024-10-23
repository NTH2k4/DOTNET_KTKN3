using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_Employee
{
    internal class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = BEATER\\KTKN3; Database = EmployeeDb; Trusted_Connection = True; TrustServerCertificate = True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

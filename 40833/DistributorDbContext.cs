using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40833
{
    internal class DistributorDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = BEATER\\KTKN3; Database = DistributorDb; Trusted_Connection = True; Trust Server Certificate = True;");
        }
        public DbSet<Distributor> Distributors { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40834
{
    internal class AuthorDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = BEATER\\KTKN3; Database = AuthorDb; Trusted_Connection = True; TrustServerCertificate = True;");
        }
        public DbSet<Author> Authors { get; set; }
    }
}

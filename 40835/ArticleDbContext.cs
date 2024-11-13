using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40835
{
    internal class ArticleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = BEATER\\KTKN3; Database = ArticleDb; Trusted_Connection = True; Trust Server Certificate = True;");
        }
        public DbSet<Article> Articles { get; set; }
    }
}

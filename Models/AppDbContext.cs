using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace TP03.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("default conection") { }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
                  optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionStrin
            g("DefaultConnection"));
        }
    }

}
}

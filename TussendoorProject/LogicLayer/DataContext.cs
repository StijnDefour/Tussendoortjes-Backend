using LogicLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogicLayer
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tussendoor> Tussendoortjes { get; set; }
        public DbSet<Doel> Doelen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = RUBENSEGERS13BC\\SQLEXPRESS; Database = tussendoor; Trusted_Connection = True;");
        }
    }
}

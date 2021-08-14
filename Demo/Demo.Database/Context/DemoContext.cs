using Demo.Database.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Demo.Database.Context
{
    public class DemoContext : DbContext
    {
        public DbSet<Speaker> Speaker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PRM8AD3;Database=DemoDB;Trusted_Connection=True;");
        }
    }
}
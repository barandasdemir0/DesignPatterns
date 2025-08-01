using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DesignPatternMediator;integrated security=True; TrustServerCertificate=True;");
        }
        public DbSet<Product>? Products { get; set; }
    }
}

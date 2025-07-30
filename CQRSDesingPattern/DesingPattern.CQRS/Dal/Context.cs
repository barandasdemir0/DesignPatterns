using Microsoft.EntityFrameworkCore;

namespace DesingPattern.CQRS.Dal
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DesingPatternCQRS;integrated security=True; TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}

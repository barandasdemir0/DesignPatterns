using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Composite.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DesingPatternComposite;integrated security=True; TrustServerCertificate=True;");
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}

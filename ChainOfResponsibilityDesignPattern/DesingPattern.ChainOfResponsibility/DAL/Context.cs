using Microsoft.EntityFrameworkCore;

namespace DesingPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DesingPatternChainOfResponsibility;integrated security=True; TrustServerCertificate=True;");

        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}

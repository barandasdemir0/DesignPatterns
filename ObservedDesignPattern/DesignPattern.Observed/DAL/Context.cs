using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observed.DAL
{

//    Çünkü sen AppUser : IdentityUser<int> ve AppRole : IdentityRole<int> şeklinde int türünde ID kullanıyorsun.Bu durumda Context sınıfında da bu int tipini açıkça belirtmen zorunlu.

//Eğer belirtmezsen (yani sadece IdentityDbContext<AppUser> yazarsan), varsayılan olarak Id türü string kabul edilir ve tip uyuşmazlığı hatası alırsın.
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DesingPatternObserver;integrated security=True; TrustServerCertificate=True;");
        }
        public DbSet<Discount>? Discounts { get; set; }
        public DbSet<UserProcess>? UserProcesses { get; set; }
        public DbSet<WelcomeMessage>? WelcomeMessages { get; set; }
    }
}

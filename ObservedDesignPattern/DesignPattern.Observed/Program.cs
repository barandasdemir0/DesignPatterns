using DesignPattern.Observed.DAL;
using DesignPattern.Observed.ObserverPattern;

namespace DesignPattern.Observed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<Context>();
            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            builder.Services.AddSingleton<ObserverObject>(sp =>
            {
                ObserverObject observerObject = new();
                observerObject.RegisterObserver(new CreateWelcomeMessage(sp));
                observerObject.RegisterObserver(new CreateMagazineAnnouncement(sp));
                observerObject.RegisterObserver(new CreateDiscountCode(sp));
                return observerObject;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
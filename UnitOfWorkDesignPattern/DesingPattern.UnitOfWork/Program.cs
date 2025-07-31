using DesingPattern.BusinessLayerUOW.Abstract;
using DesingPattern.BusinessLayerUOW.Concrete;
using DesingPattern.DataAccessLayerUOW.Abstract;
using DesingPattern.DataAccessLayerUOW.Concrete;
using DesingPattern.DataAccessLayerUOW.EntityFramework;
using DesingPattern.DataAccessLayerUOW.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DesingPattern.UnitOfWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();





            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
            opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddControllersWithViews();


            builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
            builder.Services.AddScoped<ICustomerService, CustomerManager>();
            builder.Services.AddScoped<IUowDal, UowDal>();








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
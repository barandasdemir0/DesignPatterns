using DesignPattern.BusinessLayerRepository.Abstract;
using DesignPattern.BusinessLayerRepository.Concrete;
using DesingPattern.DataAccessLayerRepository.Abstract;
using DesingPattern.DataAccessLayerRepository.Concrete;
using DesingPattern.DataAccessLayerRepository.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();




            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICategoryService,CategoryManager>();//ıcategoryservice görürsen categorymanager çağır
            builder.Services.AddScoped<ICategoryDal,EfCategoryDal>(); //ıcategorydal görürsen efcategorydal çağır


            builder.Services.AddScoped<IProductService,ProductManager>();//ıcategoryservice görürsen categorymanager çağır
            builder.Services.AddScoped<IProductDal, EfProductDal>(); //ıcategorydal görürsen efcategorydal çağır









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
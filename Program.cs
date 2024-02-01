using EcommerceMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddDbContext<Hshop2023Context>((options) =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDBURL"));
            });
            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.MapControllers();
            app.MapRazorPages();
            app.UseAuthorization();
            app.Run();
        }
    }
}
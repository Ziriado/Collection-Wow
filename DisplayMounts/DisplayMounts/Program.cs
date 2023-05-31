using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DisplayMounts.Data;
namespace DisplayMounts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DisplayMountsContextConnection") ?? throw new InvalidOperationException("Connection string 'DisplayMountsContextConnection' not found.");

            builder.Services.AddDbContext<DisplayMountsContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<Areas.Identity.Data.DisplayMountsUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DisplayMountsContext>();

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var app = builder.Build();

            app.UseCookiePolicy();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();

        }
    }
}
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using static LexiconLMSBlazor.Server.Controllers.AppUsersController;

namespace LexiconLMSBlazor.Server
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false) // Ändrade till false pga inloggningsproblem.
                .AddRoles<IdentityRole>() // ny
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
                {
                    options.IdentityResources["openid"].UserClaims.Add("role"); // ny
                    options.ApiResources.Single().UserClaims.Add("role"); // ny
                });

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("role"); // Ny

            builder.Services.AddAuthentication()
                .AddIdentityServerJwt();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // SeedData av Björn Lindqvist och Jean-Yves Michel
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();


                //db.Database.EnsureDeleted(); // Om en ny seedning ska göras vid varje uppstart.
                //db.Database.Migrate();
                //db.Database.EnsureCreated();

                try
                {
                    await SeedDataMin.InitAsync(db, serviceProvider);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}
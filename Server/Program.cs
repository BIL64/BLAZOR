using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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

            builder.Services.AddAuthentication()
                .AddIdentityServerJwt();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // SeedData av Jean-Yves Michel
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                //db.Database.EnsureDeleted(); // Om en ny seedning ska göras vid varje uppstart.
                //db.Database.Migrate();
                //db.Database.EnsureCreated();

                try
                {
                    await SeedDataMin.InitAsync(db, serviceProvider); // Här väljer man typ av seed.
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            // FÖRFARANDE FÖR ATT SKAPA EN NY MIGRATION
            // ========================================
            // Genom att radera och skapa nya migrationer kan du ofta lösa beroendeproblem och
            // säkerställa att din databas är i linje med den senaste koden.
            // OBS. Lärare, elever, kurser och moduler försvinner!
            //
            // 1. Öppna Tools > NuGet Package Manager > Package Manager Console.
            // Följande kommandon i konsolen ska skrivas:
            // 2. remove-migration (om inte databasen kan tas bort här måste man radera den i SQL-SOE)
            // 3. add-migration "Init"
            // 4. update-database
            // Nu finns en ny migration och databas tillgänglig.
            // Clear solution och rebuild solution rensar upp!

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
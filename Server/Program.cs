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
            // OBS. Lärare, elever, kurser, moduler och dokument försvinner!
            //
            // 1. Öppna Tools > NuGet Package Manager > Package Manager Console.
            // Följande kommandon i konsolen ska skrivas:
            // 2. remove-migration (om inte databasen kan tas bort här måste man radera den i SQL-SOE)
            // 3. add-migration "Init"
            // 4. update-database
            // Nu finns en ny migration och databas tillgänglig.
            // Clear solution och rebuild solution rensar upp!

            // FÖRFARANDE FÖR ATT UPPGRADERA NETX - FRAMEWORK - VERSIONEN
            // ==========================================================
            // Ibland är det nödvändigt eftersom vissa NuGets inte kan uppdateras i en gammal netversion.
            // NuGets är utspridda i projektet! En för Client, en för Server och en för Shared.
            // Netversionen finns i .csproj-filerna. Det är tre stycken här (enligt ovan).
            // Man kan även klicka i projektet, exempelvis på "LexiconLMSBlazor.Client".
            //
            // Under <PropertyGroup> nästan högst upp finns <TargetFramework>net7.0</TargetFramework>
            // Ändra siffran för varje projektfil och bygg sedan om hela projektet (rebuild solution).
            // Nu kan man konstatera fel i projektet men det brukar bara vara ett fåtal - beror på hur välskriven koden är...

            // ANVÄNDBARA GIT-KOMMANDON I CMD
            // ==============================
            // Det är oftast enklare att utföra vissa git-operationer i CMD (finns i gitmenyn).
            // Välj först vilken gren som det gäller (längst ned i högra hörnet).
            //
            // För att byta gren (branch) i CMD: "git checkout <gren>"
            // Titta på alla commits och dess ID-nummer: "git log" Här kan man kopiera ett id för en intressant commit.
            // Skapa en ny gren: "git checkout -b <ny-gren-namn>" Växlar till denna gren.
            // Om man vill slå ihop en gren med den man befinner sig i (huvudgrenen): "git merge <annan-gren-namn>".
            // Spara ändringar tillfälligt: "git stash". Återställ det stashade: "git stash pop".
            // Hämta in en commit som man vill jobba med: "git checkout <commit-id>" Kör gärna "dotnet restore" efteråt.
            // Om man vill förkasta de ändringar man gjort: "git reset --hard HEAD" Görs innan man hämtar en ny commit.
            // För att kopiera in en commit från en annan gren till den gren man befinner sig i: "git cherry-pick <commit-id>".
            // För att återställa paketen (NuGets): "dotnet restore" Om det misslyckats så kan man fixa det manuellt i .csproj-filen.
            // Olösta konflikter visas med: "git status".
            // Lägg till de lösta filerna (tidigare konflikter) till stagingområdet med kommandot: "git add <filnamn>".
            // För att avsluta cherry-pick-processen och skapa en commit: "git cherry-pick --continue".
            // Push till GitHub: "git push <huvudgrenen>".

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
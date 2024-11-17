using Duende.IdentityServer.EntityFramework.Options;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LexiconLMSBlazor.Server.Data
{
    public class ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : ApiAuthorizationDbContext<ApplicationUser>(options, operationalStoreOptions)
    {
        public DbSet<Course> Course { get; set; } = default!;
        public DbSet<Module> Module { get; set; } = default!;
        public DbSet<Activity> Activity { get; set; } = default!;
        public DbSet<ActivityType> ActivityType { get; set; } = default!;
        public DbSet<Document> Document { get; set; } = default!;
        public DbSet<Auxiliary> Auxiliary { get; set; } = default!;
        public DbSet<Forum> Forum { get; set; } = default!;
        public DbSet<Thumb> Thumb { get; set; } = default!;
    }
}
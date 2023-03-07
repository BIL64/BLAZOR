using Duende.IdentityServer.EntityFramework.Options;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LexiconLMSBlazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<LexiconLMSBlazor.Server.Models.Course> Course { get; set; } = default!;
        public DbSet<LexiconLMSBlazor.Server.Models.Module> Module { get; set; } = default!;
        public DbSet<LexiconLMSBlazor.Server.Models.Activity> Activity { get; set; } = default!;
        public DbSet<LexiconLMSBlazor.Server.Models.ActivityType> ActivityType { get; set; } = default!;
        public DbSet<LexiconLMSBlazor.Server.Models.Document> Document { get; set; } = default!;
    }
}
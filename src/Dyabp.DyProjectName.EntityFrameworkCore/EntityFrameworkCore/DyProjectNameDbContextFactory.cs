using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dyabp.DyProjectName.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DyProjectNameDbContextFactory : IDesignTimeDbContextFactory<DyProjectNameDbContext>
    {
        public DyProjectNameDbContext CreateDbContext(string[] args)
        {
            DyProjectNameEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DyProjectNameDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DyProjectNameDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Dyabp.DyProjectName.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

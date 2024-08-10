using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CDST.Files.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class FilesDbContextFactory : IDesignTimeDbContextFactory<FilesDbContext>
{
    public FilesDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        FilesEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<FilesDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new FilesDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CDST.Files.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

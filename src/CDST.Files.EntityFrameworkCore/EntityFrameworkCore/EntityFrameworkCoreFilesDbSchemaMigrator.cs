using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CDST.Files.Data;
using Volo.Abp.DependencyInjection;

namespace CDST.Files.EntityFrameworkCore;

public class EntityFrameworkCoreFilesDbSchemaMigrator
    : IFilesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFilesDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FilesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FilesDbContext>()
            .Database
            .MigrateAsync();
    }
}

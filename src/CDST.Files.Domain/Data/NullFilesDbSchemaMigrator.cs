using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CDST.Files.Data;

/* This is used if database provider does't define
 * IFilesDbSchemaMigrator implementation.
 */
public class NullFilesDbSchemaMigrator : IFilesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

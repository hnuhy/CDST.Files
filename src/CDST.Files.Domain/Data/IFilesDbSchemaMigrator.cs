using System.Threading.Tasks;

namespace CDST.Files.Data;

public interface IFilesDbSchemaMigrator
{
    Task MigrateAsync();
}

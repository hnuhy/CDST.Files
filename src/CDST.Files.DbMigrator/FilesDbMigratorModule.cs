using CDST.Files.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CDST.Files.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FilesEntityFrameworkCoreModule),
    typeof(FilesApplicationContractsModule)
)]
public class FilesDbMigratorModule : AbpModule
{
}

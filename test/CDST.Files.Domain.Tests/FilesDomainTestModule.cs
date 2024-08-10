using Volo.Abp.Modularity;

namespace CDST.Files;

[DependsOn(
    typeof(FilesDomainModule),
    typeof(FilesTestBaseModule)
)]
public class FilesDomainTestModule : AbpModule
{

}

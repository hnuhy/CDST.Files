using Volo.Abp.Modularity;

namespace CDST.Files;

[DependsOn(
    typeof(FilesApplicationModule),
    typeof(FilesDomainTestModule)
)]
public class FilesApplicationTestModule : AbpModule
{

}

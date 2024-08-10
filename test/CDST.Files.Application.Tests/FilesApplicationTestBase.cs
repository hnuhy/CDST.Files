using Volo.Abp.Modularity;

namespace CDST.Files;

public abstract class FilesApplicationTestBase<TStartupModule> : FilesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

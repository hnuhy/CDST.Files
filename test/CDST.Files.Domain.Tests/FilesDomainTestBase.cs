using Volo.Abp.Modularity;

namespace CDST.Files;

/* Inherit from this class for your domain layer tests. */
public abstract class FilesDomainTestBase<TStartupModule> : FilesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

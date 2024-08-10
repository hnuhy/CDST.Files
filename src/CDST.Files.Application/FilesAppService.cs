using CDST.Files.Localization;
using Volo.Abp.Application.Services;

namespace CDST.Files;

/* Inherit your application services from this class.
 */
public abstract class FilesAppService : ApplicationService
{
    protected FilesAppService()
    {
        LocalizationResource = typeof(FilesResource);
    }
}

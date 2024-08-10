using CDST.Files.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CDST.Files.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FilesController : AbpControllerBase
{
    protected FilesController()
    {
        LocalizationResource = typeof(FilesResource);
    }
}

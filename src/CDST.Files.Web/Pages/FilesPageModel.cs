using CDST.Files.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CDST.Files.Web.Pages;

public abstract class FilesPageModel : AbpPageModel
{
    protected FilesPageModel()
    {
        LocalizationResourceType = typeof(FilesResource);
    }
}

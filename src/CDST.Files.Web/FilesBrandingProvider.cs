using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CDST.Files.Web;

[Dependency(ReplaceServices = true)]
public class FilesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Files";
}

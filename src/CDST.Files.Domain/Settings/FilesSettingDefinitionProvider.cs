using Volo.Abp.Settings;

namespace CDST.Files.Settings;

public class FilesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FilesSettings.MySetting1));
    }
}

using CDST.Files.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace CDST.Files.Permissions;

public class FilesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FilesPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(FilesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FilesResource>(name);
    }
}

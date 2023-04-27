using ShortUrl.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ShortUrl.Permissions;

public class ShortUrlPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ShortUrlPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ShortUrlPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShortUrlResource>(name);
    }
}

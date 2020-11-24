using Kamrad.Multimedia.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kamrad.Multimedia.Permissions
{
    public class MultimediaPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MultimediaPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MultimediaPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MultimediaResource>(name);
        }
    }
}

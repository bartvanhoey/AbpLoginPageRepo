using LoginPage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LoginPage.Permissions
{
    public class LoginPagePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoginPagePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(LoginPagePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoginPageResource>(name);
        }
    }
}

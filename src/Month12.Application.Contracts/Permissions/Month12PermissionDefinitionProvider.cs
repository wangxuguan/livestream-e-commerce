using Month12.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Month12.Permissions
{
    public class Month12PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Month12Permissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Month12Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Month12Resource>(name);
        }
    }
}

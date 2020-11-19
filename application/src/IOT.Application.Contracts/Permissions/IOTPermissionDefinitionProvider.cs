using IOT.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IOT.Permissions
{
    public class IOTPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(IOTPermissions.GroupName);

            var booksPermission = myGroup.AddPermission(IOTPermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(IOTPermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(IOTPermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(IOTPermissions.Books.Delete, L("Permission:Books.Delete"));
            //Define your own permissions here. Example:
            //myGroup.AddPermission(IOTPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<IOTResource>(name);
        }
    }
}

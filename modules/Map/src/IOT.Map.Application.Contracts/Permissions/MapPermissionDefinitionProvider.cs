using IOT.Map.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IOT.Map.Permissions
{
    public class MapPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MapPermissions.GroupName, L("Permission:Map"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MapResource>(name);
        }
    }
}
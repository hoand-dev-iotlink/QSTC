using Volo.Abp.Reflection;

namespace IOT.Map.Permissions
{
    public class MapPermissions
    {
        public const string GroupName = "Map";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MapPermissions));
        }
    }
}
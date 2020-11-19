using System.Threading.Tasks;
using IOT.Map.Localization;
using Volo.Abp.UI.Navigation;

namespace IOT.Map.Blazor.Host
{
    public class MapHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<MapResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "Map.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}

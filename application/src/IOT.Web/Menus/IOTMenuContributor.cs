using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using IOT.Localization;
using IOT.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace IOT.Web.Menus
{
    public class IOTMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<IOTResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(IOTMenus.Home, l["Menu:Home"], "~/"));
            // var bookStoreMenu = new ApplicationMenuItem(
            //    "BooksStore",
            //    l["Menu:BookStore"],
            //    icon: "fa fa-book"
            //);
            //context.Menu.AddItem(bookStoreMenu);
            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "BooksStore",
                    l["Menu:BookStore"],
                    icon: "fa fa-book"
                ).AddItem(
                    new ApplicationMenuItem(
                        "BooksStore.Books",
                        l["Menu:Books"],
                        url: "/Books"
                    )
                )
            );
        }
    }
}

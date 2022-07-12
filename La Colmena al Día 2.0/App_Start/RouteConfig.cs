using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace La_Colmena_al_Día_2._0
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}

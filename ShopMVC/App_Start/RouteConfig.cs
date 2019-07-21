using System.Web.Mvc;
using System.Web.Routing;

namespace ShopMVC
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Pages",
                url: "{page}",
                result: MVC.Home.Pages()
                );

            routes.MapRoute(
                name: "Category",
                url: "category/{categoryId}",
                defaults: new { controller = MVC.Courses.Name, action = MVC.Courses.ActionNames.List }
                );

            routes.MapRoute(
                name: "Course",
                url: "course/{courseId}",
                defaults: new { controller = MVC.Courses.Name, action = MVC.Courses.ActionNames.Details }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.Index }
            );
        }
    }
}
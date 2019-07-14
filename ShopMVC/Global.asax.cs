using ShopMVC.App_Start;
using ShopMVC.Services;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace ShopMVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterFilters(GlobalFilters.Filters);
            ViewEnginesConfig.Setup();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            if (exception != null)
            {
                var logger = UnityConfig.Container.Resolve<ILoggerService>();
                logger.Fatal(exception, "Application error");
            }
        }
    }
}
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
        private ILoggerService logger;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterFilters(GlobalFilters.Filters);
            ViewEnginesConfig.Setup();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            logger = UnityConfig.Container.Resolve<ILoggerService>();
            logger.Info(nameof(Application_Start));
        }

        protected void Application_End()
        {
            logger.Info(nameof(Application_End));
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            if (exception != null)
            {
                logger.Fatal(exception, "Application error");
            }
        }
    }
}
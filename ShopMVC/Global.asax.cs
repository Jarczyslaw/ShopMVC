using ShopMVC.App_Start;
using ShopMVC.Services;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace ShopMVC
{
    public class MvcApplication : HttpApplication
    {
        private readonly Lazy<ILoggerService> logger = new Lazy<ILoggerService>(() => UnityConfig.Container.Resolve<ILoggerService>());
        private ILoggerService LoggerInstance => logger.Value;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterFilters(GlobalFilters.Filters);
            ViewEnginesConfig.Setup();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            LoggerInstance.Info(nameof(Application_Start));
        }

        protected void Application_End()
        {
            LoggerInstance.Info(nameof(Application_End));
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            if (exception != null)
            {
                LoggerInstance.Fatal(exception, "Application error");
            }
        }
    }
}
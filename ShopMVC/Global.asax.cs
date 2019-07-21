using ShopMVC.App_Start;
using ShopMVC.Code;
using ShopMVC.Services;
using System;
using System.Diagnostics;
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
        private readonly Lazy<ApplicationData> applicationData = new Lazy<ApplicationData>(() => new ApplicationData(HttpContext.Current.Application));
        private ApplicationData ApplicationDataInstance => applicationData.Value;

        protected void Application_Start()
        {
            ApplicationSetup();

            ApplicationDataInstance.ResetSessions();
            LogInfo(nameof(Application_Start));
        }

        private void ApplicationSetup()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterFilters(GlobalFilters.Filters);
            ViewEnginesConfig.Setup();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {
            LogInfo(nameof(Application_End));
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            if (exception != null)
            {
                LoggerInstance.Fatal(exception, "Application error");
            }
        }

        protected void Session_Start()
        {
            LogInfo($"Session started. ID: {HttpContext.Current.Session.SessionID}. Sessions count: {ApplicationDataInstance.AddSession()}");
        }

        protected void Session_End()
        {
            LogInfo($"Session ended. ID: {HttpContext.Current.Session.SessionID}. Sessions count: {ApplicationDataInstance.AddSession()}");
        }

        private void LogInfo(string message)
        {
            LoggerInstance.Info(message);
            Debug.WriteLine(message);
        }
    }
}
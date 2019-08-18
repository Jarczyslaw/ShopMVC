using ShopMVC.Services;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopMVC.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly ILoggerService logger;

        public BaseController()
        {
        }

        public BaseController(ILoggerService logger)
        {
            this.logger = logger;
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            SetCulture();
        }

        private void SetCulture()
        {
            const string culture = "en-US";
            Thread.CurrentThread.CurrentCulture
                = Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            logger.Fatal(exception);

            var controller = (string)filterContext.RouteData.Values["controller"];
            var action = (string)filterContext.RouteData.Values["action"];
            filterContext.Result = new PartialViewResult()
            {
                ViewName = MVC.Shared.Views._Error,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(new HandleErrorInfo(exception, controller, action))
            };

            filterContext.ExceptionHandled = true;
            base.OnException(filterContext);
        }
    }
}
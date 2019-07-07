using NLog;
using ShopMVC.App_Code;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly IAppConfig appConfiguration;
        protected readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public BaseController()
        {
        }

        public BaseController(IAppConfig appConfiguration)
        {
            this.appConfiguration = appConfiguration;
        }

        public virtual ActionResult Subview(string targetView, object viewModel)
        {
            var subviewViewModel = new SubviewViewModel()
            {
                TargetView = targetView,
                TargetViewModel = viewModel
            };
            return View(MVC.Shared.Views._Layout, subviewViewModel);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            logger.Log(LogLevel.Fatal, exception);

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
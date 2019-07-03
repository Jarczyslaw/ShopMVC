using ShopMVC.App_Code;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly IAppConfig appConfiguration;

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
    }
}
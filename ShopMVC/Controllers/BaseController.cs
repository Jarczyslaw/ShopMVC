using ShopMVC.App_Code;
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
    }
}
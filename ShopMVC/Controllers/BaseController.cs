using ShopMVC.App_Code;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly IAppConfiguration appConfiguration;

        public BaseController()
        {
        }

        public BaseController(IAppConfiguration appConfiguration)
        {
            this.appConfiguration = appConfiguration;
        }
    }
}
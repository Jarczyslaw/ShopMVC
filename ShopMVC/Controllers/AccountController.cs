using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class AccountController : BaseController
    {
        public AccountController(ILoggerService logger)
            : base(logger)
        {
        }

        public virtual ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction(MVC.Home.Index());
        }

        public virtual ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction(MVC.Home.Index());
        }
    }
}
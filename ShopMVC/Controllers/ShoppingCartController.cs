using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class ShoppingCartController : BaseController
    {
        private readonly IShoppingCartService shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService, ILoggerService logger)
            : base(logger)
        {
            this.shoppingCartService = shoppingCartService;
        }

        public virtual ActionResult Index()
        {
            return Subview(MVC.ShoppingCart.Views.Index, new ShoppingCartViewModel());
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartCount()
        {
            return new ContentResult()
            {
                Content = shoppingCartService.GetContentCount().ToString()
            };
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartValue()
        {
            return new ContentResult()
            {
                Content = shoppingCartService.GetContentValue().ToString("C")
            };
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartLink()
        {
            return PartialView(MVC.Partial.Views._ShoppingCartLink, new ShoppingCartLinkViewModel
            {
                Count = shoppingCartService.GetContentCount(),
                Value = shoppingCartService.GetContentValue()
            });
        }
    }
}
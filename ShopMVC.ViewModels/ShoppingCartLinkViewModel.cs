using ShopMVC.Commons.Extensions;

namespace ShopMVC.ViewModels
{
    public class ShoppingCartLinkViewModel : BaseViewModel
    {
        public int Count { get; set; }
        public decimal Value { get; set; }
        public string ValueDisp => Value.ToCurrency();
    }
}
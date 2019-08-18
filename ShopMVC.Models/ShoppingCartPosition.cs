using ShopMVC.Commons.Extensions;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.Models
{
    public class ShoppingCartPosition
    {
        public Course Course { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string PriceDisp => Price.ToCurrency();

        public decimal Value => Quantity * Price;

        public string ValueDisp => Value.ToCurrency();
    }
}
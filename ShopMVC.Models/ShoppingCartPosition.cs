using ShopMVC.DataAccess.Models;

namespace ShopMVC.Models
{
    public class ShoppingCartPosition
    {
        public Course Course { get; set; }
        public int Quantity { get; set; }
        public decimal Value => Quantity * Course.Price;
    }
}
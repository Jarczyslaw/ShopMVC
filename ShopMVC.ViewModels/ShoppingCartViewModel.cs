using ShopMVC.Commons.Extensions;
using ShopMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.ViewModels
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public IEnumerable<ShoppingCartPosition> Positions { get; set; }
        public decimal Value { get; set; }
        public string ValueDisp => Value.ToCurrency();
        public int PositionsCount => Positions?.Count() ?? 0;
    }
}
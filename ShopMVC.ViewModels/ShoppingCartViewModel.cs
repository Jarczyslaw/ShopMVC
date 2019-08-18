using ShopMVC.Commons.Extensions;
using ShopMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.ViewModels
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public IEnumerable<ShoppingCartPosition> Positions { get; set; }
        public int PositionsCount => Positions?.Count() ?? 0;
        public string TotalValue => Positions?.Sum(p => p.Value).ToCurrency() ?? string.Empty;
        public bool ContainsPayments => Positions?.Any(p => p.Value > 0) == true;
    }
}
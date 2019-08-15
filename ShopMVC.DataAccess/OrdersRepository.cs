using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.DataAccess
{
    public class OrdersRepository : BaseRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(IDataContextFactory dataContextFactory)
            : base(dataContextFactory)
        {
        }
    }
}
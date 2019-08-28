using ShopMVC.DataAccess.Abstraction;

namespace ShopMVC.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IOrdersRepository ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository, IUnitOfWork unitOfWork)
        {
            this.ordersRepository = ordersRepository;
            this.unitOfWork = unitOfWork;
        }
    }
}
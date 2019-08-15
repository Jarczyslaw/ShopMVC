using ShopMVC.DataAccess.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using ShopMVC.DataAccess.Abstraction;
using ShopMVC.Commons;

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
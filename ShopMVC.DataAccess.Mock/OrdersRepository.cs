using Nelibur.ObjectMapper;
using ShopMVC.Commons;
using ShopMVC.Commons.Extensions;
using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopMVC.DataAccess.Mock
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly IDataContextProvider dataContextProvider;

        public OrdersRepository(IDataContextProvider dataContextProvider)
        {
            this.dataContextProvider = dataContextProvider;
        }

        public void Add(Order entity)
        {
            entity.OrderId = GetNextId();
            dataContextProvider.Orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            var order = GetById(entity.OrderId);
            dataContextProvider.Orders.Remove(order);
        }

        public void Delete(Expression<Func<Order, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Order Get(Expression<Func<Order, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetMany(Expression<Func<Order, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }

        private int GetNextId()
        {
            return dataContextProvider.Orders.SafeMax(o => o.OrderId) + 1;
        }
    }
}
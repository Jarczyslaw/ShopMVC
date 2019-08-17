using ShopMVC.Commons.Abstraction;
using ShopMVC.DataAccess.Models;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ISessionProvider sessionProvider;

        private string CartContentKey => nameof(CartContentKey);

        public ShoppingCartService(ISessionProvider sessionProvider)
        {
            this.sessionProvider = sessionProvider;
        }

        public List<ShoppingCartPosition> GetContent()
        {
            var result = sessionProvider.Get<List<ShoppingCartPosition>>(CartContentKey);
            if (result == null)
            {
                result = new List<ShoppingCartPosition>();
            }
            return result;
        }

        public int GetContentCount()
        {
            return GetContent().Sum(c => c.Quantity);
        }

        public decimal GetContentValue()
        {
            return GetContent().Sum(c => c.Value);
        }

        public void Add(Course course)
        {
            var cart = GetContent();
            var cartPosition = cart.SingleOrDefault(c => c.Course.CourseId == course.CourseId);
            if (cartPosition == null)
            {
                cart.Add(new ShoppingCartPosition
                {
                    Quantity = 1,
                    Course = course,
                    Price = course.Price
                });
            }
            else
            {
                cartPosition.Quantity++;
            }
            sessionProvider.Set(CartContentKey, cart);
        }

        public void Remove(int courseId)
        {
            var cart = GetContent();
            var cartPosition = cart.SingleOrDefault(c => c.Course.CourseId == courseId);
            if (cartPosition != null)
            {
                if (cartPosition.Quantity > 1)
                {
                    cartPosition.Quantity--;
                }
                else
                {
                    cart.Remove(cartPosition);
                }
            }
            sessionProvider.Set(CartContentKey, cart);
        }

        public void Clear()
        {
            sessionProvider.Set<List<ShoppingCartPosition>>(CartContentKey, null);
        }

        public Order CreateOrder(string userId)
        {
            var cart = GetContent();
            var order = new Order
            {
                AddedDate = DateTime.Now,
                UserId = userId
            };

            order.OrderItems = cart.Select(c => new OrderItem
            {
                CourseId = c.Course.CourseId,
                Quantity = c.Quantity,
                Price = c.Price
            }).ToList();

            return order;
        }
    }
}
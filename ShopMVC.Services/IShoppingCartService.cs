using ShopMVC.DataAccess.Models;
using ShopMVC.Models;
using System.Collections.Generic;

namespace ShopMVC.Services
{
    public interface IShoppingCartService
    {
        List<ShoppingCartPosition> GetContent();

        int GetContentCount();

        decimal GetContentValue();

        void Add(Course course);

        void Remove(int courseId);

        void Clear();

        Order CreateOrder(string userId);
    }
}
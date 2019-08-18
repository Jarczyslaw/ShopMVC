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

        int GetPositionCount(int courseId);

        decimal GetPositionValue(int courseId);

        int Remove(int courseId);

        void Clear();

        Order CreateOrder(string userId);
    }
}
using ShopMVC.Models;
using System.Collections.Generic;

namespace ShopMVC.Commons
{
    public interface IShoppingCartStorage
    {
        List<ShoppingCartPosition> GetContent();

        int GetContentCount();

        decimal GetContentValue();

        void Add(int courseId);

        void Remove(int courseId);
    }
}
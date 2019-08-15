using ShopMVC.Commons;
using ShopMVC.DataAccess.Commons;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.DataAccess.Mock
{
    public class DataContextProvider : IDataContextProvider
    {
        private string CategoriesKey => nameof(CategoriesKey);
        private string CoursesKey => nameof(CoursesKey);
        private string OrdersKey => nameof(OrdersKey);
        private string OrderItemsKey => nameof(OrderItemsKey);

        private readonly IMemoryCacheProvider memoryCacheProvider;

        public DataContextProvider(IMemoryCacheProvider memoryCacheProvider)
        {
            this.memoryCacheProvider = memoryCacheProvider;
            Load();
        }

        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public void Load()
        {
            var expiration = TimeSpan.FromDays(1);
            Categories = memoryCacheProvider.GetOrSet(CategoriesKey, SampleDataSource.GetCategories, expiration)
                .ToList();
            Courses = memoryCacheProvider.GetOrSet(CoursesKey, SampleDataSource.GetCourses, expiration)
                .ToList();
            Orders = memoryCacheProvider.GetOrSet(OrdersKey, () => new List<Order>(), expiration)
                .ToList();
            OrderItems = memoryCacheProvider.GetOrSet(OrderItemsKey, () => new List<OrderItem>(), expiration)
                .ToList();
        }

        public void Save()
        {
            memoryCacheProvider.Set(CategoriesKey, Categories, TimeSpan.MaxValue);
            memoryCacheProvider.Set(CoursesKey, Courses, TimeSpan.MaxValue);
            memoryCacheProvider.Set(OrdersKey, Orders, TimeSpan.MaxValue);
            memoryCacheProvider.Set(OrderItemsKey, OrderItemsKey, TimeSpan.MaxValue);
        }
    }
}
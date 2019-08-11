using ShopMVC.Commons;
using ShopMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ISessionProvider sessionProvider;
        private readonly ICoursesService coursesService;

        private readonly string cartContentKey = "CartContentKey";

        public ShoppingCartService(ISessionProvider sessionProvider, ICoursesService coursesService)
        {
            this.sessionProvider = sessionProvider;
            this.coursesService = coursesService;
        }

        public List<ShoppingCartPosition> GetContent()
        {
            var result = sessionProvider.Get<List<ShoppingCartPosition>>(cartContentKey);
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

        public void Add(int courseId)
        {
            var cart = GetContent();
            var cartPosition = cart.SingleOrDefault(c => c.Course.CourseId == courseId);
            if (cartPosition == null)
            {
                var course = coursesService.GetCourseById(courseId);
                if (course != null)
                {
                    cart.Add(new ShoppingCartPosition
                    {
                        Quantity = 1,
                        Course = course
                    });
                }
            }
            else
            {
                cartPosition.Quantity++;
            }
            sessionProvider.Set(cartContentKey, cart);
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
            sessionProvider.Set(cartContentKey, cart);
        }

        public void Clear()
        {
            sessionProvider.Set<List<ShoppingCartPosition>>(cartContentKey, null);
        }

        public Order CreateOrder()
        {
            // TODO
            return new Order();
        }
    }
}
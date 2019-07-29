using ShopMVC.DataAccess.Models;
using System.Collections.Generic;

namespace ShopMVC.Services
{
    public interface ICategoriesService
    {
        Category GetCategoryById(int id);

        IEnumerable<Category> GetAll();
        IEnumerable<Category> GetCategoriesList();
    }
}
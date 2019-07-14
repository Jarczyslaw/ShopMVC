using ShopMVC.DataAccess.Models;
using System.Collections.Generic;

namespace ShopMVC.DataAccess.Mock
{
    public interface IDataContextProvider
    {
        List<Category> Categories { get; }
        List<Course> Courses { get; }
        void Load();
        void Save();
    }
}
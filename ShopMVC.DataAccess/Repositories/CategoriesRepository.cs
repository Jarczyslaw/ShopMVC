using ShopMVC.DataAccess.Factories;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.DataAccess.Repositories
{
    public class CategoriesRepository : BaseRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(IDataContextFactory dataContextFactory)
            : base(dataContextFactory)
        {
        }
    }
}
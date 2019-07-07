using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.DataAccess
{
    public class CategoriesRepository : BaseRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(IDataContextFactory dataContextFactory)
            : base(dataContextFactory)
        {
        }
    }
}
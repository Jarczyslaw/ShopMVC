using ShopMVC.DataAccess.Factories;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.DataAccess.Repositories
{
    public class CoursesRepository : BaseRepository<Course>, ICoursesRepository
    {
        public CoursesRepository(IDataContextFactory dataContextFactory)
            : base(dataContextFactory)
        {
        }
    }
}
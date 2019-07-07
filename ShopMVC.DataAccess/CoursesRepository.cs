using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;

namespace ShopMVC.DataAccess
{
    public class CoursesRepository : BaseRepository<Course>, ICoursesRepository
    {
        public CoursesRepository(IDataContextFactory dataContextFactory)
            : base(dataContextFactory)
        {
        }
    }
}
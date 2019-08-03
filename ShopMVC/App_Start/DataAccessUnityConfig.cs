using ShopMVC.Commons;
using ShopMVC.DataAccess;
using ShopMVC.DataAccess.Abstraction;
using Unity;

namespace ShopMVC.App_Start
{
    public class DataAccessUnityConfig : BaseDataAccessUnityConfig
    {
        public override void RegisterTypes(IUnityContainer container)
        {
            container.RegisterForRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterForRequest<IDataContextFactory, DataContextFactory>();
            container.RegisterForRequest<ICoursesRepository, CoursesRepository>();
            container.RegisterForRequest<ICategoriesRepository, CategoriesRepository>();
        }
    }
}
using ShopMVC.Commons;
using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Mock;
using Unity;

namespace ShopMVC.App_Start
{
    public class MockDataAccessUnityConfig : BaseDataAccessUnityConfig
    {
        public override void RegisterTypes(IUnityContainer container)
        {
            container.RegisterForRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterForRequest<IDataContextProvider, DataContextProvider>();
            container.RegisterForRequest<ICoursesRepository, CoursesRepository>();
            container.RegisterForRequest<ICategoriesRepository, CategoriesRepository>();
        }
    }
}
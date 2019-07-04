using ShopMVC.App_Code;
using ShopMVC.Commons;
using ShopMVC.DataAccess.Repositories;
using ShopMVC.DataAccess.UnitsOfWork;
using ShopMVC.Services;
using System;
using Unity;

namespace ShopMVC
{
    public static class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        public static IUnityContainer Container => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAppConfig, AppConfig>();
            container.RegisterType<IContentCache, ContentCache>();

            RegisterDataAccessDependencies(container);
            RegisterServices(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterForRequest<ICoursesService, CoursesService>();
            container.RegisterForRequest<ICategoriesService, CategoriesService>();
        }

        private static void RegisterDataAccessDependencies(IUnityContainer container)
        {
            container.RegisterForRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterForRequest<ICoursesRepository, CoursesRepository>();
            container.RegisterForRequest<ICategoriesRepository, CategoriesRepository>();
        }
    }
}
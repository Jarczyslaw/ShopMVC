using ShopMVC.Code;
using ShopMVC.Commons;

#if MOCK

using ShopMVC.DataAccess.Mock;

#else

using ShopMVC.DataAccess;

#endif

using ShopMVC.DataAccess.Abstraction;
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
            container.RegisterSingleton<ILoggerService, LoggerService>();
            container.RegisterSingleton<IHttpContextCacheProvider, HttpContextCacheProvider>();
            container.RegisterSingleton<IMemoryCacheProvider, MemoryCacheProvider>();
            container.RegisterSingleton<IAppCache, AppCache>();
            container.RegisterSingleton<ISessionProvider, SessionProvider>();

            RegisterDataAccessDependencies(container);
            RegisterServices(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterForRequest<ICoursesService, CoursesService>();
            container.RegisterForRequest<ICategoriesService, CategoriesService>();
        }

#if MOCK

        private static void RegisterDataAccessDependencies(IUnityContainer container)
        {
            container.RegisterForRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterForRequest<IDataContextProvider, DataContextProvider>();
            container.RegisterForRequest<ICoursesRepository, CoursesRepository>();
            container.RegisterForRequest<ICategoriesRepository, CategoriesRepository>();
        }

#else

        private static void RegisterDataAccessDependencies(IUnityContainer container)
        {
            container.RegisterForRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterForRequest<IDataContextFactory, DataContextFactory>();
            container.RegisterForRequest<ICoursesRepository, CoursesRepository>();
            container.RegisterForRequest<ICategoriesRepository, CategoriesRepository>();
        }

#endif
    }
}
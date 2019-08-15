using ShopMVC.App_Start;
using ShopMVC.Code;
using ShopMVC.Commons;
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

        private static void RegisterDataAccessDependencies(IUnityContainer container)
        {
            BaseDataAccessUnityConfig config = null;
#if MOCK
            config = new MockDataAccessUnityConfig();
#else
            config = new DataAccessUnityConfig();
#endif
            config.RegisterTypes(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterForRequest<ICoursesService, CoursesService>();
            container.RegisterForRequest<ICategoriesService, CategoriesService>();
            container.RegisterSingleton<IShoppingCartService, ShoppingCartService>();
        }
    }
}
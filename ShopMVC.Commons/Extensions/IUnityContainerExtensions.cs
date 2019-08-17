using Unity;
using Unity.AspNet.Mvc;

namespace ShopMVC.Commons.Extensions
{
    public static class IUnityContainerExtensions
    {
        public static void RegisterForRequest<T1, T2>(this IUnityContainer container)
            where T2 : T1
        {
            container.RegisterType<T1, T2>(new PerRequestLifetimeManager());
        }
    }
}
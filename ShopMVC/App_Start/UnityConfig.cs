using ShopMVC.App_Code;
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
        }
    }
}
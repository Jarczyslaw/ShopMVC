using Unity;

namespace ShopMVC.App_Start
{
    public abstract class BaseDataAccessUnityConfig
    {
        public abstract void RegisterTypes(IUnityContainer container);
    }
}
namespace ShopMVC.Code
{
    public interface ISessionProvider
    {
        T Get<T>(string key);

        void Set<T>(string key, T value);

        void Abandon();
    }
}
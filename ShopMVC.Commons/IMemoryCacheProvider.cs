using System.Runtime.Caching;

namespace ShopMVC.Commons
{
    public interface IMemoryCacheProvider : ICacheProvider
    {
        MemoryCache Cache { get; }
    }
}
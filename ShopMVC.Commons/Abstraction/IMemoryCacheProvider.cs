using System.Runtime.Caching;

namespace ShopMVC.Commons.Abstraction
{
    public interface IMemoryCacheProvider : ICacheProvider
    {
        MemoryCache Cache { get; }
    }
}
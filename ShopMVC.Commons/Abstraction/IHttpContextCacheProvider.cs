using System.Web.Caching;

namespace ShopMVC.Commons.Abstraction
{
    public interface IHttpContextCacheProvider : ICacheProvider
    {
        Cache Cache { get; }
    }
}
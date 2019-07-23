using System.Web.Caching;

namespace ShopMVC.Commons
{
    public interface IHttpContextCacheProvider : ICacheProvider
    {
        Cache Cache { get; }
    }
}
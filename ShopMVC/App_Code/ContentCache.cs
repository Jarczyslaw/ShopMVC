namespace ShopMVC.App_Code
{
    public class ContentCache : IContentCache
    {
        private readonly ICacheProvider cacheProvider;

        public ContentCache(ICacheProvider cacheProvider)
        {
            this.cacheProvider = cacheProvider;
        }
    }
}
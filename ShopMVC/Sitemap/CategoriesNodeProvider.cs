using MvcSiteMapProvider;
using ShopMVC.Services;
using System.Collections.Generic;
using Unity;

namespace ShopMVC.Sitemap
{
    public class CategoriesNodeProvider : DynamicNodeProviderBase
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesNodeProvider()
        {
            categoriesService = UnityConfig.Container.Resolve<ICategoriesService>();
        }

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var nodes = new List<DynamicNode>();
            foreach (var category in categoriesService.GetAll())
            {
                var newNode = new DynamicNode()
                {
                    Title = category.Title,
                    Key = "Category_" + category.CategoryId,
                };
                newNode.RouteValues.Add("categoryId", category.CategoryId);
                nodes.Add(newNode);
            }
            return nodes;
        }
    }
}
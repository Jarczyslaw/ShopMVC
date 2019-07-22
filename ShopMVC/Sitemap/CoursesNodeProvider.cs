using MvcSiteMapProvider;
using ShopMVC.Services;
using System.Collections.Generic;
using Unity;

namespace ShopMVC.Sitemap
{
    public class CoursesNodeProvider : DynamicNodeProviderBase
    {
        private readonly ICoursesService coursesService;

        public CoursesNodeProvider()
        {
            coursesService = UnityConfig.Container.Resolve<ICoursesService>();
        }

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var nodes = new List<DynamicNode>();
            foreach (var course in coursesService.GetAll())
            {
                var newNode = new DynamicNode()
                {
                    Title = course.Title,
                    Key = "Course_" + course.CourseId,
                    ParentKey = "Category_" + course.CategoryId,
                };
                newNode.RouteValues.Add("courseId", course.CourseId);
                nodes.Add(newNode);
            }
            return nodes;
        }
    }
}
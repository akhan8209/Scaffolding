using System.Web;
using System.Web.Mvc;

namespace Scaffolding_With_Area_in_Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

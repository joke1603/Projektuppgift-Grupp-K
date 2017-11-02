using System.Web;
using System.Web.Mvc;

namespace Projektuppgift___Grupp_K
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

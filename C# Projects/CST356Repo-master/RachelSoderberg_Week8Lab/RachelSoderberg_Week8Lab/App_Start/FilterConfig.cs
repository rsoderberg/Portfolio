using System.Web;
using System.Web.Mvc;

namespace RachelSoderberg_Week8Lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

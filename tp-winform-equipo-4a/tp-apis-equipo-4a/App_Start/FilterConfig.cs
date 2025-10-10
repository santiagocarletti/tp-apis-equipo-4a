using System.Web;
using System.Web.Mvc;

namespace tp_apis_equipo_4a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

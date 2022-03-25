using System.Web;
using System.Web.Mvc;

namespace _1911065192_HuynhHaiDang_BiogSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

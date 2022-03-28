using System.Web;
using System.Web.Mvc;

namespace _19DTHC2_BigSchool_HaiDang_1911065192
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

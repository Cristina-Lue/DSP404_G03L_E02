using System.Web;
using System.Web.Mvc;

namespace Turnover_SA_de_CV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

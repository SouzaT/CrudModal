using System.Web.Mvc;
using EP.CrudModalDDD.Infra.CrossCutting.MvcFilters;

namespace EP.CrudModalDDD.UI.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}

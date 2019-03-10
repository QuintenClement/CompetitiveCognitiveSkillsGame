using System.Web;
using System.Web.Mvc;

namespace Multiplayer_Competitive_Cognitive_Skills_Game
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

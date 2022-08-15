using System.Web.Mvc;

namespace SpotifyUI.Areas.HouTai
{
    public class HouTaiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HouTai";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HouTai_default",
                "HouTai/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces:new string[]{"SpotifyUI.Areas.HouTai"}
            );
        }
    }
}
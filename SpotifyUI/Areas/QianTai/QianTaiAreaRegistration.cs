using System.Web.Mvc;

namespace SpotifyUI.Areas.QianTai
{
    public class QianTaiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QianTai";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QianTai_default",
                "QianTai/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
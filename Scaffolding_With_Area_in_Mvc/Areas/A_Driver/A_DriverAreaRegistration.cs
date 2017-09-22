using System.Web.Mvc;

namespace Scaffolding_With_Area_in_Mvc.Areas.A_Driver
{
    public class A_DriverAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "A_Driver";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "A_Driver_default",
                "A_Driver/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
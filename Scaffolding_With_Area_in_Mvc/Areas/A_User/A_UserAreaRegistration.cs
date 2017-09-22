using System.Web.Mvc;

namespace Scaffolding_With_Area_in_Mvc.Areas.A_User
{
    public class A_UserAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "A_User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "A_User_default",
                "A_User/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
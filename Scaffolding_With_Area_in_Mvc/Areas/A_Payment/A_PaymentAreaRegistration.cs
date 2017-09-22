using System.Web.Mvc;

namespace Scaffolding_With_Area_in_Mvc.Areas.A_Payment
{
    public class A_PaymentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "A_Payment";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "A_Payment_default",
                "A_Payment/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
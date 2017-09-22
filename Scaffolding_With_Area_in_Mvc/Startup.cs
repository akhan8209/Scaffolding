using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scaffolding_With_Area_in_Mvc.Startup))]
namespace Scaffolding_With_Area_in_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

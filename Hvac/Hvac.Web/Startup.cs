using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hvac.Web.Startup))]
namespace Hvac.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

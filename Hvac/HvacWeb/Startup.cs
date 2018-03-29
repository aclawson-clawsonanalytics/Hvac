using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HvacWeb.Startup))]
namespace HvacWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

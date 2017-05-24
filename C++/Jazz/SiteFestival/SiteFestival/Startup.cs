using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteFestival.Startup))]
namespace SiteFestival
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

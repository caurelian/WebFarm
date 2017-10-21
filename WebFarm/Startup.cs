using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFarm.Startup))]
namespace WebFarm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

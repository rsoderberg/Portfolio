using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RachelSoderberg_Week8Lab.Startup))]
namespace RachelSoderberg_Week8Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

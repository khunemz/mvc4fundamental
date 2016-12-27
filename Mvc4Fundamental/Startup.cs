using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc4Fundamental.Startup))]
namespace Mvc4Fundamental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

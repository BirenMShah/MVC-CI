using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CI.Startup))]
namespace MVC_CI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

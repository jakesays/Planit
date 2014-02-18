using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Planit.Startup))]
namespace Planit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

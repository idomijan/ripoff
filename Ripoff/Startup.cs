using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ripoff.Startup))]
namespace Ripoff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

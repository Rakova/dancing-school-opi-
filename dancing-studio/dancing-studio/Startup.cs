using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dancing_studio.Startup))]
namespace dancing_studio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

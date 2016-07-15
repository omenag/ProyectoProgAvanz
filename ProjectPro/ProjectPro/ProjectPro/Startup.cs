using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectPro.Startup))]
namespace ProjectPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

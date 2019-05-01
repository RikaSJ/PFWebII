using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinePapu.Startup))]
namespace CinePapu
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

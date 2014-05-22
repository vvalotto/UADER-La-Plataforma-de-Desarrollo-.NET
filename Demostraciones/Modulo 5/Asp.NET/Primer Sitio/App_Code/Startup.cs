using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Primer_Sitio.Startup))]
namespace Primer_Sitio
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

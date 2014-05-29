using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IronManMVC.Startup))]
namespace IronManMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

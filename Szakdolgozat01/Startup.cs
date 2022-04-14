using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Szakdolgozat01.Startup))]
namespace Szakdolgozat01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

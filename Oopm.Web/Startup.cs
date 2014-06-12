using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oopm.Web.Startup))]
namespace Oopm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

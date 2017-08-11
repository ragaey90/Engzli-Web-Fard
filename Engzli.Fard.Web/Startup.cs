using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Engzli.Fard.Web.Startup))]
namespace Engzli.Fard.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

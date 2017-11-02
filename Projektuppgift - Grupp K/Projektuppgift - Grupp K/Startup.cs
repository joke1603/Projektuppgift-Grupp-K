using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projektuppgift___Grupp_K.Startup))]
namespace Projektuppgift___Grupp_K
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

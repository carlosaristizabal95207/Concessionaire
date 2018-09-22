using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Concessionaire.Backend.Startup))]
namespace Concessionaire.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

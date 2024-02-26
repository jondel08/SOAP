using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pacagroup.Comercial.Creditos.WebConsumer2.Startup))]
namespace Pacagroup.Comercial.Creditos.WebConsumer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

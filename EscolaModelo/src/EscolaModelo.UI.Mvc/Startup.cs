using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EscolaModelo.UI.Mvc.Startup))]
namespace EscolaModelo.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

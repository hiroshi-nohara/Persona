using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVALON.Iekei.Persona.Startup))]
namespace AVALON.Iekei.Persona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

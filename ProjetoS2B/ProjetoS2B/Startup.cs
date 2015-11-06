using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoS2B.Startup))]
namespace ProjetoS2B
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

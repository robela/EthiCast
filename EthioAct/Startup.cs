using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EthioAct.Startup))]
namespace EthioAct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

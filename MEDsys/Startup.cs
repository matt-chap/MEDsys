using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEDsys.Startup))]
namespace MEDsys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

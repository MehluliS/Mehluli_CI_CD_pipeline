using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SLDFA2Mehluli.Startup))]
namespace SLDFA2Mehluli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

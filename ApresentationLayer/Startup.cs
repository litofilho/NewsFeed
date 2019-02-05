using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApresentationLayer.Startup))]
namespace ApresentationLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

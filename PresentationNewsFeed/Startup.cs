using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PresentationNewsFeed.Startup))]
namespace PresentationNewsFeed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

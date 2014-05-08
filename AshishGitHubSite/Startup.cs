using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AshishGitHubSite.Startup))]
namespace AshishGitHubSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

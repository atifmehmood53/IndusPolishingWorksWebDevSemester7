using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWithAuth.Startup))]
namespace ProjectWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

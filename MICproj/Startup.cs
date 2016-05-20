using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MICproj.Startup))]
namespace MICproj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

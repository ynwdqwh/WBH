using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WBHWeb.Startup))]
namespace WBHWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

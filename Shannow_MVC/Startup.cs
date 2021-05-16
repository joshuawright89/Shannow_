using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shannow_MVC.Startup))]
namespace Shannow_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

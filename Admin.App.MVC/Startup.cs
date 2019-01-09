using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin.App.MVC.Startup))]
namespace Admin.App.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

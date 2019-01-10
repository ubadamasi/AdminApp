using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin.App.Mvc.Startup))]
namespace Admin.App.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

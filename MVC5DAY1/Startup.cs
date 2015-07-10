using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5DAY1.Startup))]
namespace MVC5DAY1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

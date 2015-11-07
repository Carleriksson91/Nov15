using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nov15.Startup))]
namespace Nov15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

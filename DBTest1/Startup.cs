using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBTest1.Startup))]
namespace DBTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

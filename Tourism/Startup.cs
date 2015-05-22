using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tourism.Startup))]
namespace Tourism
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

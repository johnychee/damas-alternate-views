using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Damas_alternate_views.Startup))]
namespace Damas_alternate_views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallStore.Startup))]
namespace SmallStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

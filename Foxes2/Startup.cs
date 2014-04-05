using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Foxes2.Startup))]
namespace Foxes2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

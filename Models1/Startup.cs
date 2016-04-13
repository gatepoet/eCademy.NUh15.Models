using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Models1.Startup))]
namespace Models1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoWebDemo.Startup))]
namespace VideoWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

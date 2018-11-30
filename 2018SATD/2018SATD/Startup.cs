using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_2018SATD.Startup))]

namespace _2018SATD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
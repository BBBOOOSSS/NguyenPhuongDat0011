using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenphuongdat.Startup))]
namespace nguyenphuongdat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065192_BigSchool_HaiDang.Startup))]
namespace _1911065192_BigSchool_HaiDang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

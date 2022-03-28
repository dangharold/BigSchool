using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_19DTHC2_BigSchool_HaiDang_1911065192.Startup))]
namespace _19DTHC2_BigSchool_HaiDang_1911065192
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

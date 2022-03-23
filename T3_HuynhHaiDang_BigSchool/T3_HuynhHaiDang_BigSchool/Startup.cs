using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T3_HuynhHaiDang_BigSchool.Startup))]
namespace T3_HuynhHaiDang_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

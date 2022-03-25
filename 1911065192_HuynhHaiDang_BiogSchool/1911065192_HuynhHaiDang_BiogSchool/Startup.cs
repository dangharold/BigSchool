using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065192_HuynhHaiDang_BiogSchool.Startup))]
namespace _1911065192_HuynhHaiDang_BiogSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

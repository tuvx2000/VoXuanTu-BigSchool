using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoXuanTu_BigSchool1.Startup))]
namespace VoXuanTu_BigSchool1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

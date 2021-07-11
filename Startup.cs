using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoXuanTu_BigSchool001.Startup))]
namespace VoXuanTu_BigSchool001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

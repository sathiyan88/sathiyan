using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistDevAPP.Startup))]
namespace DentistDevAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

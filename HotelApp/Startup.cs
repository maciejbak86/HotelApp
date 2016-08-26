using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelApp.Startup))]
namespace HotelApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(mySupperClubService.Startup))]

namespace mySupperClubService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week5_day1_indv.Startup))]
namespace week5_day1_indv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

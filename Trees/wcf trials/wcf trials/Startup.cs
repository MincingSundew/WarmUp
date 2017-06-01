using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wcf_trials.Startup))]
namespace wcf_trials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

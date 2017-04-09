using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewApp.Startup))]
namespace InterviewApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

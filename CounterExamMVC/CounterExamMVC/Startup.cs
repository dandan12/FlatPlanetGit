using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CounterExamMVC.Startup))]
namespace CounterExamMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

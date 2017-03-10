using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSoln.Startup))]
namespace TestSoln
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

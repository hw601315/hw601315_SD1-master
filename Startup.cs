using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hw601315_SD1.Startup))]
namespace hw601315_SD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

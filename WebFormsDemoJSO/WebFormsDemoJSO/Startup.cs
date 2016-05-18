using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsDemoJSO.Startup))]
namespace WebFormsDemoJSO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

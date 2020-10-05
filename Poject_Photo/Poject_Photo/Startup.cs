using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poject_Photo.Startup))]
namespace Poject_Photo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewModelAssignment.Startup))]
namespace ViewModelAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

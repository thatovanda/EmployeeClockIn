using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeClockIn.Startup))]
namespace EmployeeClockIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

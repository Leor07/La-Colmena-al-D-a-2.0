using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(La_Colmena_al_Día_2._0.Startup))]
namespace La_Colmena_al_Día_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

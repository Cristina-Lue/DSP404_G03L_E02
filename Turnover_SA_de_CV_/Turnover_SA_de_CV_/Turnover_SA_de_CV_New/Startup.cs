using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Turnover_SA_de_CV_New.StartupOwin))]

namespace Turnover_SA_de_CV_New
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}

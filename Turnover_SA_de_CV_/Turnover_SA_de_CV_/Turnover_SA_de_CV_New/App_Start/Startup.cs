using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(Turnover_SA_de_CV.Startup))]

namespace Turnover_SA_de_CV
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Habilitar la autenticación mediante cookies
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                LogoutPath = new PathString("/Account/LogOff"),
                ExpireTimeSpan = TimeSpan.FromMinutes(30), // Tiempo de expiración de la sesión
            });

            // Configurar el contexto de la base de datos y el administrador de usuarios
            // Esto se conectará con tu connectionString en Web.config
            app.CreatePerOwinContext<ApplicationDbContext>(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
        }
    }
}
using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using AxadoCarrier;

[assembly: OwinStartup(typeof(Startup))]

namespace AxadoCarrier
{
    public class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void Configuration(IAppBuilder app)
        {
            var options = new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                SlidingExpiration = true,
                ExpireTimeSpan = new TimeSpan(0, 30, 0) //authentication timeout of 30 minutes of inactivity (equal to session timeout)
            };
            app.UseCookieAuthentication(options);
        }
    }
}
using AxadoCarrier.Identity;
using AxadoCarrier.WebApplication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AxadoCarrier.Controllers
{
    public partial class AccountController : Controller
    {
        public AxodoCarrierUserIdentityService IdentityService { get; set; }

        public AccountController()
        {
            this.IdentityService = new AxodoCarrierUserIdentityService();
        }

        [AllowAnonymous]
        public virtual ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            var loginViewModel = new LoginViewModel();

            return View(loginViewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public async virtual Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (model.Username == null) model.Username = string.Empty;
            if (model.Password == null) model.Password = string.Empty;
            
            var user = await this.IdentityService.UserManager.FindAsync(model.Username, model.Password);

            if(user != null)
            {
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                var identity = this.IdentityService.UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                var properties = new AuthenticationProperties { IsPersistent = true };
                authenticationManager.SignIn(properties, identity);

                HttpContext.Session["CurrentUser"] = model.Username;

                return RedirectToAction(MVC.Carrier.Index());
            }

            return View(model);
        }
    }
}
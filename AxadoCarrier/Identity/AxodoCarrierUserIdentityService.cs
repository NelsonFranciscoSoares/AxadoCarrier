using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AxadoCarrier.Identity
{
    public class AxodoCarrierUserIdentityService
    {
        public UserManager<AxodoCarrierUser> UserManager { get; private set; }

        public AxodoCarrierUserIdentityService()
        {
            var dbContext = new AxodoCarrierIdentityDbContext();
            this.UserManager = new UserManager<AxodoCarrierUser>(new UserStore<AxodoCarrierUser>(dbContext));
        }
    }
}
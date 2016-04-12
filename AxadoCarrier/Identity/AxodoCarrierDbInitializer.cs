using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AxadoCarrier.Identity
{
    public class AxodoCarrierDbInitializer : CreateDatabaseIfNotExists<AxodoCarrierIdentityDbContext>
    {
        protected override void Seed(AxodoCarrierIdentityDbContext context)
        {
            var user1 = new AxodoCarrierUser{ UserName="Teste1"};
            var user2 = new AxodoCarrierUser{ UserName="Teste2"};

            using(var userManager = new UserManager<AxodoCarrierUser>(new UserStore<AxodoCarrierUser>(context)))
            {
                userManager.Create(user1, "Password1234!");
                userManager.Create(user2, "Password1234!");

            }
            base.Seed(context);
        }
    }
}
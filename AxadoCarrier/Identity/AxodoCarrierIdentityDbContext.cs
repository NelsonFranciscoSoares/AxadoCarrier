using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AxadoCarrier.Identity
{
    public class AxodoCarrierIdentityDbContext : IdentityDbContext<AxodoCarrierUser>
    {
        public AxodoCarrierIdentityDbContext()
            : base("AxodoCarrierIdentityDbContext")
        {
            Database.SetInitializer(new AxodoCarrierDbInitializer());
        }
    }
}
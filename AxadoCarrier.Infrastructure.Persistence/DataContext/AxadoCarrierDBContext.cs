﻿using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.DataContext
{
    public class AxadoCarrierDBContext : DbContext
    {
        private DbSet<Carrier> Carrier { get; set; }
        private DbSet<Vote> Vote { get; set; }
        private DbSet<User> User { get; set; }
       
        public AxadoCarrierDBContext()
            : base("name=AxadoCarrierDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.Log = System.Console.WriteLine;
            Database.SetInitializer(new NullDatabaseInitializer<AxadoCarrierDBContext>());
        }
    }
}

using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.EFConfigurations
{
    public abstract class BaseEntityConfiguration<T> : EntityTypeConfiguration<T>
        where T : BaseEntity
    {
        protected BaseEntityConfiguration()
        {
            this.HasKey(param => param.Id);
        }
    }
}

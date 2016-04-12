using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.EFConfigurations
{
    public class CarrierConfiguration : BaseEntityConfiguration<Carrier>
    {
        public CarrierConfiguration()
        {
            this.Property(param => param.Name)
                .IsRequired();

            this.HasMany(param => param.Votes)
                .WithRequired(param => param.Carrier)
                .HasForeignKey(param => param.Id)
                .WillCascadeOnDelete(true);
        }
    }
}

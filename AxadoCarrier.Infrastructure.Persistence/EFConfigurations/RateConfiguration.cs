using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.EFConfigurations
{
    public class RateConfiguration : BaseEntityConfiguration<Rate>
    {
        public RateConfiguration()
        {
            this.HasRequired(param => param.User)
                .WithMany(param => param.Votes)
                .HasForeignKey(param => param.UserId);
        }
    }
}

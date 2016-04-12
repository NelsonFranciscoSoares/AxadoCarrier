using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.EFConfigurations
{
    public class VoteConfiguration : BaseEntityConfiguration<Vote>
    {
        public VoteConfiguration()
        {
            this.HasRequired(param => param.User)
                .WithMany(param => param.Votes)
                .HasForeignKey(param => param.UserId);
        }
    }
}

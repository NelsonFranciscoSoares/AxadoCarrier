using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Entities
{
    public class Vote : BaseEntity
    {
        public Guid CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int Classification { get; set; } 
    }
}

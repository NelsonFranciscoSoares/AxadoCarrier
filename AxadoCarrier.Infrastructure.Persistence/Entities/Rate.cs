using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Entities
{
    public class Rate : BaseEntity
    {
        public Guid CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public String Username { get; set; }
        public int RateValue { get; set; } 
    }
}

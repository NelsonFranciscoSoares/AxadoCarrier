using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence
{
    public class Carrier : BaseEntity
    {
        public List<Rate> Votes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Entities
{
    public class User : BaseEntity
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public List<Rate> Votes { get; set; }
    }
}

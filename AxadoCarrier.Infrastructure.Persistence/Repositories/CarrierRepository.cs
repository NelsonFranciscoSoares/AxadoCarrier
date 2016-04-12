using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Repositories
{
    public class CarrierRepository : Repository<Carrier>
    {
        public CarrierRepository(DbContext dataContext)
            :base(dataContext)
        {

        }
    }
}

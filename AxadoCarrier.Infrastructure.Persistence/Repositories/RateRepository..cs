using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Repositories
{
    public class RateRepository : Repository<Rate>
    {
        public RateRepository(DbContext dataContext)
            :base(dataContext)
        {
            
        }

        public Rate Get(Guid carrierId, String username)
        {
            return this.DataSet
                .Where(param => param.CarrierId == carrierId && param.Username == username)
                .FirstOrDefault();
        }

        public bool CheckIfUserAlreadyRates(Guid carrierId, String username)
        {
            return 
                this.DataSet
                    .FirstOrDefault(param => param.Username == username && param.CarrierId == carrierId) != null;
        }
    }
}

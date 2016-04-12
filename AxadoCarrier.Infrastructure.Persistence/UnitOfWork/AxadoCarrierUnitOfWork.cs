using AxadoCarrier.Infrastructure.Persistence.DataContext;
using AxadoCarrier.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.UnitOfWork
{
    public class AxadoCarrierUnitOfWork
    {
        private AxadoCarrierDBContext DbContext {get; set;}
        public CarrierRepository CarrierRepository { get; private set; }
        public RateRepository RateRepository { get; private set; }

        public AxadoCarrierUnitOfWork()
        {
            this.DbContext = new AxadoCarrierDBContext();
            this.CarrierRepository = new CarrierRepository(this.DbContext);
            this.RateRepository = new RateRepository(this.DbContext);
        }

        public void Commit()
        {
            this.DbContext.SaveChanges();
        }
    }
}

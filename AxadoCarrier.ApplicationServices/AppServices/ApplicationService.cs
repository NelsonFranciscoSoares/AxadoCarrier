using AxadoCarrier.Infrastructure.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.ApplicationServices.AppServices
{
    public abstract class ApplicationService
    {
        protected AxadoCarrierUnitOfWork UnitOfWork { get; private set; }
        
        protected ApplicationService()
        {
            this.UnitOfWork = new AxadoCarrierUnitOfWork();
        }
    }
}

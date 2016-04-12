using AxadoCarrier.ApplicationServices.AppServices;
using AxadoCarrier.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.ApplicationServices
{
    public class RateCarrierApplicationService : ApplicationService
    {
        public void Create()
        {

        }

        public void Update()
        {

        }

        public CarrierRateViewModel Get(Guid carrierId, String username)
        {
            var rateCarrier = this.UnitOfWork.RateRepository.Get(carrierId, username);

            return new CarrierRateViewModel
            {
                
            };
        }
    }
}

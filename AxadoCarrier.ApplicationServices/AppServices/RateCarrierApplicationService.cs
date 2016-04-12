using AxadoCarrier.ApplicationServices.AppServices;
using AxadoCarrier.Infrastructure.Persistence.Entities;
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
        public Guid Create(CarrierRateViewModel viewModel)
        {
            var carrierRate = new Rate
            {
                CarrierId = viewModel.Id,
                RateValue = viewModel.RateValue.Value,
                Username = viewModel.Username,
                Id = Guid.NewGuid(),
                Description = viewModel.RateDescription
            };

            this.UnitOfWork.RateRepository.Add(carrierRate);
            this.UnitOfWork.Commit();

            return carrierRate.Id;
        }

        public void Update(CarrierRateViewModel viewModel)
        {
            var carrierRate = new Rate
            {
                Id = viewModel.RateId.Value,
                CarrierId = viewModel.Id,
                RateValue = viewModel.RateValue.Value,
                Description = viewModel.RateDescription,
                Username = viewModel.Username
            };

            this.UnitOfWork.RateRepository.Update(carrierRate);
            this.UnitOfWork.Commit();
        }

        public CarrierRateViewModel Get(Guid carrierId, String username)
        {
            var carrier = this.UnitOfWork.CarrierRepository.Get(carrierId);
            var carrierRate = this.UnitOfWork.RateRepository.Get(carrierId, username);

            var carrierRateViewModel = new CarrierRateViewModel
            {
                Id = carrierId,
                Name = carrier.Name,
                Description = carrier.Description,
                RateDescription = carrierRate != null ? carrierRate.Description : String.Empty,
                RateId = carrierRate != null ? carrierRate.Id : (Guid?)null,
                RateValue = carrierRate != null ? carrierRate.RateValue : (int?)null
            };

            return carrierRateViewModel;
        }
    }
}

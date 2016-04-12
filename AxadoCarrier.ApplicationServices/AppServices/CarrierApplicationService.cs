using AxadoCarrier.ApplicationServices.AppServices;
using AxadoCarrier.Infrastructure.Persistence;
using AxadoCarrier.WebApplication.Models.CarrierModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.ApplicationServices
{
    public class CarrierApplicationService : ApplicationService
    {
        public Guid Create(CarrierViewModel viewModel)
        {
            var carrier = new Carrier{
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                Description = viewModel.Description
            };

            this.UnitOfWork.CarrierRepository.Add(carrier);
            this.UnitOfWork.Commit();

            return carrier.Id;
        }

        public void Update(CarrierViewModel viewModel)
        {
            var carrier = new Carrier
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };

            this.UnitOfWork.CarrierRepository.Update(carrier);
            this.UnitOfWork.Commit();
        }

        public IEnumerable<CarrierViewModel> GetAll()
        {
            var carriers = this.UnitOfWork.CarrierRepository.GetAll();

            return carriers.Select(param => new CarrierViewModel
            {
                Id = param.Id,
                Name = param.Name,
                Description = param.Description
            });
        }

        public CarrierViewModel Get(Guid id)
        {
            var carrier = this.UnitOfWork.CarrierRepository.Get(id);

            return new CarrierViewModel
            {
                Id = id,
                Name = carrier.Name,
                Description = carrier.Description
            };
        }

        public void Delete(Guid id)
        {
            this.UnitOfWork.CarrierRepository.Delete(id);
            this.UnitOfWork.Commit();
        }
    }
}

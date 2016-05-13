using System.ServiceModel;
using AxadoCarrier.ApplicationServices;

namespace AxadoCarrier.Infrastructure.WCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WCFAxadoWS : IWCFAxadoWS
    {
        private CarrierApplicationService CarrierApplicationService { get; set; }
        private RateCarrierApplicationService RateCarrierApplicationService { get; set; }

        public WCFAxadoWS()
        {
            this.CarrierApplicationService = new CarrierApplicationService();
            this.RateCarrierApplicationService = new RateCarrierApplicationService();
        }

        public System.Guid CarrierCreate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel model)
        {
            return this.CarrierApplicationService.Create(model);
        }

        public void CarrierUpdate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel viewModel)
        {
            this.CarrierApplicationService.Update(viewModel);
        }

        public System.Collections.Generic.IEnumerable<AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel> GetAllCarriers()
        {
            return this.CarrierApplicationService.GetAll();
        }

        public AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel GetCarrier(System.Guid id)
        {
            return this.CarrierApplicationService.Get(id);
        }

        public void CarrierDelete(System.Guid id)
        {
            this.CarrierApplicationService.Delete(id);
        }

        public System.Guid RateCreate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel)
        {
            return this.RateCarrierApplicationService.Create(viewModel);
        }

        public void RateUpdate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel)
        {
            this.RateCarrierApplicationService.Update(viewModel);
        }

        public AxadoCarrier.WebApplication.Models.CarrierRateViewModel Get(System.Guid carrierId, string username)
        {
            return this.RateCarrierApplicationService.Get(carrierId, username);
        }
    }
}

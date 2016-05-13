using System;
using System.Collections.Generic;
using System.ServiceModel;
using AxadoCarrier.WebApplication.Models;
using AxadoCarrier.WebApplication.Models.CarrierModels;

namespace Axado.Infrastructure.WCFHost
{
    [ServiceContract]
    public interface IWCFAxadoWS
    {
        [OperationContract]
        Guid CarrierCreate(CarrierViewModel model);

        [OperationContract]
        void CarrierUpdate(CarrierViewModel viewModel);

        [OperationContract]
        IEnumerable<CarrierViewModel> GetAllCarriers();

        [OperationContract]
        CarrierViewModel GetCarrier(Guid id);

        [OperationContract]
        void CarrierDelete(Guid id);

        [OperationContract]
        Guid RateCreate(CarrierRateViewModel viewModel);

        [OperationContract]
        void RateUpdate(CarrierRateViewModel viewModel);

        [OperationContract]
        CarrierRateViewModel GetRate(CarrierRateViewModel model);

        [OperationContract]
        bool CheckIfUserAlreadyRates(CarrierRateViewModel model);
    }
}

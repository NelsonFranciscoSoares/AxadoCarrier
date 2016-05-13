﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxadoCarrier.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IWCFAxadoWS")]
    public interface IWCFAxadoWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierCreate", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierCreateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AxadoCarrier.WebApplication.Models.CarrierRateViewModel))]
        System.Guid CarrierCreate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierCreate", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierCreateResponse")]
        System.Threading.Tasks.Task<System.Guid> CarrierCreateAsync(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierUpdate", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierUpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AxadoCarrier.WebApplication.Models.CarrierRateViewModel))]
        void CarrierUpdate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierUpdate", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierUpdateResponse")]
        System.Threading.Tasks.Task CarrierUpdateAsync(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetAllCarriers", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetAllCarriersResponse")]
        AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel[] GetAllCarriers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetAllCarriers", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetAllCarriersResponse")]
        System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel[]> GetAllCarriersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetCarrier", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetCarrierResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AxadoCarrier.WebApplication.Models.CarrierRateViewModel))]
        AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel GetCarrier(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetCarrier", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetCarrierResponse")]
        System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel> GetCarrierAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierDelete", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierDeleteResponse")]
        void CarrierDelete(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CarrierDelete", ReplyAction="http://tempuri.org/IWCFAxadoWS/CarrierDeleteResponse")]
        System.Threading.Tasks.Task CarrierDeleteAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/RateCreate", ReplyAction="http://tempuri.org/IWCFAxadoWS/RateCreateResponse")]
        System.Guid RateCreate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/RateCreate", ReplyAction="http://tempuri.org/IWCFAxadoWS/RateCreateResponse")]
        System.Threading.Tasks.Task<System.Guid> RateCreateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/RateUpdate", ReplyAction="http://tempuri.org/IWCFAxadoWS/RateUpdateResponse")]
        void RateUpdate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/RateUpdate", ReplyAction="http://tempuri.org/IWCFAxadoWS/RateUpdateResponse")]
        System.Threading.Tasks.Task RateUpdateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetRate", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetRateResponse")]
        AxadoCarrier.WebApplication.Models.CarrierRateViewModel GetRate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/GetRate", ReplyAction="http://tempuri.org/IWCFAxadoWS/GetRateResponse")]
        System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierRateViewModel> GetRateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CheckIfUserAlreadyRates", ReplyAction="http://tempuri.org/IWCFAxadoWS/CheckIfUserAlreadyRatesResponse")]
        bool CheckIfUserAlreadyRates(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAxadoWS/CheckIfUserAlreadyRates", ReplyAction="http://tempuri.org/IWCFAxadoWS/CheckIfUserAlreadyRatesResponse")]
        System.Threading.Tasks.Task<bool> CheckIfUserAlreadyRatesAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFAxadoWSChannel : AxadoCarrier.ServiceReference.IWCFAxadoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFAxadoWSClient : System.ServiceModel.ClientBase<AxadoCarrier.ServiceReference.IWCFAxadoWS>, AxadoCarrier.ServiceReference.IWCFAxadoWS {
        
        public WCFAxadoWSClient() {
        }
        
        public WCFAxadoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFAxadoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAxadoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAxadoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid CarrierCreate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel model) {
            return base.Channel.CarrierCreate(model);
        }
        
        public System.Threading.Tasks.Task<System.Guid> CarrierCreateAsync(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel model) {
            return base.Channel.CarrierCreateAsync(model);
        }
        
        public void CarrierUpdate(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel viewModel) {
            base.Channel.CarrierUpdate(viewModel);
        }
        
        public System.Threading.Tasks.Task CarrierUpdateAsync(AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel viewModel) {
            return base.Channel.CarrierUpdateAsync(viewModel);
        }
        
        public AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel[] GetAllCarriers() {
            return base.Channel.GetAllCarriers();
        }
        
        public System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel[]> GetAllCarriersAsync() {
            return base.Channel.GetAllCarriersAsync();
        }
        
        public AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel GetCarrier(System.Guid id) {
            return base.Channel.GetCarrier(id);
        }
        
        public System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierModels.CarrierViewModel> GetCarrierAsync(System.Guid id) {
            return base.Channel.GetCarrierAsync(id);
        }
        
        public void CarrierDelete(System.Guid id) {
            base.Channel.CarrierDelete(id);
        }
        
        public System.Threading.Tasks.Task CarrierDeleteAsync(System.Guid id) {
            return base.Channel.CarrierDeleteAsync(id);
        }
        
        public System.Guid RateCreate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel) {
            return base.Channel.RateCreate(viewModel);
        }
        
        public System.Threading.Tasks.Task<System.Guid> RateCreateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel) {
            return base.Channel.RateCreateAsync(viewModel);
        }
        
        public void RateUpdate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel) {
            base.Channel.RateUpdate(viewModel);
        }
        
        public System.Threading.Tasks.Task RateUpdateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel viewModel) {
            return base.Channel.RateUpdateAsync(viewModel);
        }
        
        public AxadoCarrier.WebApplication.Models.CarrierRateViewModel GetRate(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model) {
            return base.Channel.GetRate(model);
        }
        
        public System.Threading.Tasks.Task<AxadoCarrier.WebApplication.Models.CarrierRateViewModel> GetRateAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model) {
            return base.Channel.GetRateAsync(model);
        }
        
        public bool CheckIfUserAlreadyRates(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model) {
            return base.Channel.CheckIfUserAlreadyRates(model);
        }
        
        public System.Threading.Tasks.Task<bool> CheckIfUserAlreadyRatesAsync(AxadoCarrier.WebApplication.Models.CarrierRateViewModel model) {
            return base.Channel.CheckIfUserAlreadyRatesAsync(model);
        }
    }
}
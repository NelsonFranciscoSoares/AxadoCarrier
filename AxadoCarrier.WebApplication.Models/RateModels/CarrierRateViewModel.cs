using AxadoCarrier.WebApplication.Models.CarrierModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.WebApplication.Models
{
    public class CarrierRateViewModel : CarrierViewModel
    {
        public Guid? RateId { get; set; }
        public int? RateValue { get; set; }
        public String Username { get; set; }
        public String RateDescription { get; set; }
    }
}

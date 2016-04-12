using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AxadoCarrier.Controllers
{
    public partial class CarrierRateController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}
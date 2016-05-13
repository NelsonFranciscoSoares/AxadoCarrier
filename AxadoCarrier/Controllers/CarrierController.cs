using AxadoCarrier.ApplicationServices;
using AxadoCarrier.WebApplication.Models.CarrierModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AxadoCarrier.Controllers
{
    [Authorize]
    public partial class CarrierController : Controller
    {
        public CarrierController() { }

        [HttpGet]
        public virtual ActionResult Index()
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var carrierList = proxy.GetAllCarriers().ToList();

                return View(carrierList);
            }
        }

        [HttpGet]
        public virtual ActionResult Details(Guid id)
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var carrier = proxy.GetCarrier(id);

                return View(carrier);
            }
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            var model = new CarrierViewModel();
           
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Create(CarrierViewModel model)
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var id = proxy.CarrierCreate(model);

                return RedirectToAction(MVC.Carrier.Details(id));
            }
        }

        [HttpGet]
        public virtual ActionResult Edit(Guid id)
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var carrier = proxy.GetCarrier(id);

                return View(carrier);
            }
        }

        [HttpPost]
        public virtual ActionResult Edit(CarrierViewModel model)
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                proxy.CarrierUpdate(model);

                return RedirectToAction(MVC.Carrier.Details(model.Id));
            }
        }

        [HttpPost]
        public virtual ActionResult Delete(Guid id)
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
               proxy.CarrierDelete(id);

                return RedirectToAction(MVC.Carrier.Index());
            }
        }
    }
}
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
        public CarrierApplicationService CarrierApplicationService { get; set; }

        public CarrierController()
        {
            this.CarrierApplicationService = new CarrierApplicationService();
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            var carrierList = this.CarrierApplicationService.GetAll();

            return View(carrierList);
        }

        [HttpGet]
        public virtual ActionResult Details(Guid id)
        {
            var carrier = this.CarrierApplicationService.Get(id);

            return View(carrier);
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
            var id = this.CarrierApplicationService.Create(model);

            return RedirectToAction(MVC.Carrier.Details(id));
        }

        [HttpGet]
        public virtual ActionResult Edit(Guid id)
        {
            var carrier = this.CarrierApplicationService.Get(id);

            return View(carrier);
        }

        [HttpPost]
        public virtual ActionResult Edit(CarrierViewModel model)
        {
            this.CarrierApplicationService.Update(model);

            return RedirectToAction(MVC.Carrier.Details(model.Id));
        }

        [HttpPost]
        public virtual ActionResult Delete(Guid id)
        {
            this.CarrierApplicationService.Delete(id);

            return RedirectToAction(MVC.Carrier.Index());
        }
    }
}
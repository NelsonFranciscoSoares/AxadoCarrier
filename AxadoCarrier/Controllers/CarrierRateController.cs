using AxadoCarrier.ApplicationServices;
using AxadoCarrier.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AxadoCarrier.Controllers
{
    [Authorize]
    public partial class CarrierRateController : Controller
    {
        public CarrierApplicationService CarrierApplicationService { get; set; }
        public RateCarrierApplicationService RateCarrierApplicationService { get; set; }

        public CarrierRateController()
        {
            this.CarrierApplicationService = new CarrierApplicationService();
            this.RateCarrierApplicationService = new RateCarrierApplicationService();
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            var carrierList = this.CarrierApplicationService.GetAll();

            return View(carrierList);
        }

        [HttpGet]
        public virtual ActionResult Create(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            var model = this.RateCarrierApplicationService.Get(id, username);

            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Create(CarrierRateViewModel model)
        {
            var username = HttpContext.Session["CurrentUser"] as string;
            model.Username = username;

            var rateId = this.RateCarrierApplicationService.Create(model);

            return RedirectToAction(MVC.CarrierRate.Details(model.Id));
        }

        [HttpGet]
        public virtual ActionResult Details(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            var model = this.RateCarrierApplicationService.Get(id, username);
            
            return View(model);
        }

        [HttpGet]
        public virtual ActionResult Edit(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            var model = this.RateCarrierApplicationService.Get(id, username);
            model.Username = username;

            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Edit(CarrierRateViewModel model)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            this.RateCarrierApplicationService.Update(model);

            return RedirectToAction(MVC.CarrierRate.Details(model.Id));
        }
    }
}
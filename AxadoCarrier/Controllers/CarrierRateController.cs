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

        public CarrierRateController()
        {
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var carrierList = proxy.GetAllCarriers();

                return View(carrierList);
            }
        }

        [HttpGet]
        public virtual ActionResult Create(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var model = proxy.GetRate(new CarrierRateViewModel{ Id = id, Username = username});
                return View(model);
            }
        }

        [HttpPost]
        public virtual ActionResult Create(CarrierRateViewModel model)
        {
            var username = HttpContext.Session["CurrentUser"] as string;
            model.Username = username;

            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                if (proxy.CheckIfUserAlreadyRates(new CarrierRateViewModel{ Id = model.Id, Username = username}) == true)
                {
                    ModelState.AddModelError(string.Empty, "User can't vote twice.");

                    return View(model);
                }

                var rateId = proxy.RateCreate(model);

                return RedirectToAction(MVC.CarrierRate.Details(model.Id));
            }
        }

        [HttpGet]
        public virtual ActionResult Details(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var model = proxy.GetRate(new CarrierRateViewModel { Id = id, Username = username });

                return View(model);
            } 
        }

        [HttpGet]
        public virtual ActionResult Edit(Guid id)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                var model = proxy.GetRate(new CarrierRateViewModel { Id = id, Username = username });
                model.Username = username;

                return View(model);
            } 
        }

        [HttpPost]
        public virtual ActionResult Edit(CarrierRateViewModel model)
        {
            var username = HttpContext.Session["CurrentUser"] as string;

            using (var proxy = new AxadoCarrier.ServiceReference.WCFAxadoWSClient())
            {
                model.Username = username;
                proxy.RateUpdate(model);

                return RedirectToAction(MVC.CarrierRate.Details(model.Id));
            }
        }
    }
}
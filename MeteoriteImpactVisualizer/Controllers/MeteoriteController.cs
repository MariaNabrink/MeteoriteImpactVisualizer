using MeteoriteImpactVisualizer.Services;
using MeteoriteImpactVisualizer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceData.Controllers
{
    public class MeteoriteController : Controller
    {

        private IMeteoriteService _service;

        public MeteoriteController()
        {
            _service = new MeteoriteService();
        }

        // GET: Meteorite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMeteorites()
        {
            var meteorites = _service.GetById(5011);
            return Json(meteorites, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllMeteorites()
        {
            var meteorites = _service.GetAllMeteorites();
            return Json(meteorites, JsonRequestBehavior.AllowGet);
        }
    }
}
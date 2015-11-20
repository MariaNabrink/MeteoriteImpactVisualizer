using MeteoriteImpactVisualizer.Services;
using MeteoriteImpactVisualizer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoriteImpactVisualizer.Controllers
{
    public class HomeController : Controller
    {

        private IMeteoriteService _service;

        public HomeController()
        {
            _service = new MeteoriteService();
        }
    }
}
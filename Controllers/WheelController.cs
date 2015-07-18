using MyExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyExample.Controllers
{
    public class WheelController : Controller
    {
        // GET: Wheel
        public ActionResult Index()
        {
            return View();
        }

        private void LoadStuff()
        {
            Wheel wheel = new Wheel(26.0, 1.5);
            Gear gear = new Gear(52.0, 11.0, wheel);
        }
    }
}
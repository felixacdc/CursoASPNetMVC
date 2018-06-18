using AnotacionesDeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotacionesDeData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DatosPersonales(Datos obj)
        {
            if(ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}
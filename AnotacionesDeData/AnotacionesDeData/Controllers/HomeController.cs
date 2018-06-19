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
        public ActionResult DatosPersonales(DatosEmail obj)
        {
            if(ModelState.IsValid)
            {
                String email = obj.Email;
                String pass = obj.Password;

                if (email == "pablo@gmail.com" && pass == "123456")
                {
                    return View();
                }
                else
                    return View("Index");                
            }
            else
            {
                return View("Index");
            }
            
        }

        [HttpPost]
        public ActionResult MostarDatos(DatosPersonales obj)
        {
            if (ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("DatosPersonales");
            }
        }
    }
}
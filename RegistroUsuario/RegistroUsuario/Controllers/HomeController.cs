using RegistroUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RegistroUsuario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Usuarios(UserLogin datos)
        {
            if(ModelState.IsValid)
            {
                if(datos.Login())
                {
                    Session["userName"] = datos.UserName;
                    return View();
                } else
                    return View("Index");

            } else
                return View("Index");
        }
    }
}
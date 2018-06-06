using CursoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            Persona obj = new Persona();
            obj.edad = 24;
            obj.nombre = "Felix";
            obj.apellido = "Mendez";

            return View(obj);
        }
    }
}
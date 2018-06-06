using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVCParte2.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar()
        {
            String nombreProducto = RouteData.Values["nombreProducto"].ToString();
            nombreProducto = Server.HtmlEncode(nombreProducto); // convierte a texto plano html
            String resultado = string.Empty;

            switch (nombreProducto)
            {
                case "PC":
                    resultado = "Disponibles 4 unidades";
                    break;
                case "RAM":
                    resultado = "Disponibles 2 unidades";
                    break;
                default:
                    resultado = String.Format("El producto {0} no existe en stock", nombreProducto);
                    break;
            }

            return Content("<p>" + resultado + "</p>");
        }
    }
}
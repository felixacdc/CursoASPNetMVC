using CursoMVCParteTres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVCParteTres.Controllers
{
    public class ProductosController : Controller
    {
        List<Datos> producto = new List<Datos>();

        public ProductosController()
        {
            Datos obj1 = new Datos();
            obj1.Descripcion = "Manzana";
            obj1.Cantidad = 8;
            obj1.Precio = 25.20m;
            producto.Add(obj1);

            Datos obj2 = new Datos();
            obj2.Descripcion = "Bananas";
            obj2.Cantidad = 25;
            obj2.Precio = 20.20m;
            producto.Add(obj2);
        }
        // GET: Productos
        public ViewResult MostrarProducto(int id)
        {
            Datos obj1 = producto[id];
            return View(obj1);
        }
    }
}
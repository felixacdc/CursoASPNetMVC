using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnotacionesDeData.Models
{
    public class Datos
    {
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public int Edad { get; set; }
    }
}
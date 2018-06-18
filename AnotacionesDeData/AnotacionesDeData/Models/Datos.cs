using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnotacionesDeData.Models
{
    public class DatosPersonales
    {
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public int Edad { get; set; }
    }

    public class DatosEmail
    {
        [Required(ErrorMessage = "El email es requerido")]
        [Display(Name = "Correo Electronico")]
        public String Email { get; set; }

        [Required(ErrorMessage = "El password es requerido")]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }
    }
}
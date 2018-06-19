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

        //[Phone]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(?:\d*)", ErrorMessage = "Numero de telefono invalido.")]
        [Display(Name = "Numero telefonico")]
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public int Number { get; set; }
    }

    public class DatosEmail
    {
        [EmailAddress]
        [Required(ErrorMessage = "El email es requerido")]
        [Display(Name = "Correo Electronico")]
        public String Email { get; set; }

        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [Required(ErrorMessage = "El password es requerido")]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmacion no coinciden.")]
        [Display(Name = "Confirmar Contraseña")]
        public String ConfirmPassword { get; set; }
    }
}
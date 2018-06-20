using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroUsuario.Models
{
    public class UserLogin
    {
        [EmailAddress]
        [Required(ErrorMessage = "<font color='red'>El email es requerido</font>")]
        [Display(Name = "Correo Electronico")]
        public String Email { get; set; }

        [StringLength(100, ErrorMessage = "<font color='red'>El numero de caracteres de {0} debe ser al menos {2}</font>", MinimumLength = 6)]
        [Required(ErrorMessage = "<font color='red'>El password es requerido</font>")]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }

        public String UserName { get; set; }
    }
}
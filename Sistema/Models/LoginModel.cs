using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite um e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite uma senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
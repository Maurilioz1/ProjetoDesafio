using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite um nome.")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite um email.")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite uma senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirme a senha.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha é diferente.")]
        public string ConfirmarSenha { get; set; }

        public string SuccessMessage { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Sistema.Dominio
{
    public class Usuarios
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite seu nome completo.")]
        public string nomeCompleto { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite um apelido.")]
        public string apelido { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite um email.")]
        public string email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite um telefone.")]
        public string telefone { get; set; }
    }
}
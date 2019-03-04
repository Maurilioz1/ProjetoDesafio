using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio
{
    public class Clientes
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite a razão social.")]
        public string razaoSocial { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o nome fantasia.")]
        public string nomeFantasia { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o CNPJ.")]
        public string cnpj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o endereço.")]
        public string endereço { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o número.")]
        public int numero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o bairro.")]
        public string bairro { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o complemento.")]
        public string complemento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o município.")]
        public string municipio { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o CEP.")]
        public string cep { get; set; }
    }
}
